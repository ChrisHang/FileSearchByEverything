using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace WindowsApplication1
{
	public partial class Form1 : Form
	{
		int pSearchFileCount = 0;
		int pSearchSuccessCount = 0;
		int pCopySuccessCount = 0;

        const int bufsize = 260;
        const int EVERYTHING_OK = 0;
		const int EVERYTHING_ERROR_MEMORY = 1;
		const int EVERYTHING_ERROR_IPC = 2;
		const int EVERYTHING_ERROR_REGISTERCLASSEX = 3;
		const int EVERYTHING_ERROR_CREATEWINDOW = 4;
		const int EVERYTHING_ERROR_CREATETHREAD = 5;
		const int EVERYTHING_ERROR_INVALIDINDEX = 6;
		const int EVERYTHING_ERROR_INVALIDCALL = 7;

		const int EVERYTHING_REQUEST_FILE_NAME = 0x00000001;
		const int EVERYTHING_REQUEST_PATH = 0x00000002;
		const int EVERYTHING_REQUEST_FULL_PATH_AND_FILE_NAME = 0x00000004;
		const int EVERYTHING_REQUEST_EXTENSION = 0x00000008;
		const int EVERYTHING_REQUEST_SIZE = 0x00000010;
		const int EVERYTHING_REQUEST_DATE_CREATED = 0x00000020;
		const int EVERYTHING_REQUEST_DATE_MODIFIED = 0x00000040;
		const int EVERYTHING_REQUEST_DATE_ACCESSED = 0x00000080;
		const int EVERYTHING_REQUEST_ATTRIBUTES = 0x00000100;
		const int EVERYTHING_REQUEST_FILE_LIST_FILE_NAME = 0x00000200;
		const int EVERYTHING_REQUEST_RUN_COUNT = 0x00000400;
		const int EVERYTHING_REQUEST_DATE_RUN = 0x00000800;
		const int EVERYTHING_REQUEST_DATE_RECENTLY_CHANGED = 0x00001000;
		const int EVERYTHING_REQUEST_HIGHLIGHTED_FILE_NAME = 0x00002000;
		const int EVERYTHING_REQUEST_HIGHLIGHTED_PATH = 0x00004000;
		const int EVERYTHING_REQUEST_HIGHLIGHTED_FULL_PATH_AND_FILE_NAME = 0x00008000;

		const int EVERYTHING_SORT_NAME_ASCENDING = 1;
		const int EVERYTHING_SORT_NAME_DESCENDING = 2;
		const int EVERYTHING_SORT_PATH_ASCENDING = 3;
		const int EVERYTHING_SORT_PATH_DESCENDING = 4;
		const int EVERYTHING_SORT_SIZE_ASCENDING = 5;
		const int EVERYTHING_SORT_SIZE_DESCENDING = 6;
		const int EVERYTHING_SORT_EXTENSION_ASCENDING = 7;
		const int EVERYTHING_SORT_EXTENSION_DESCENDING = 8;
		const int EVERYTHING_SORT_TYPE_NAME_ASCENDING = 9;
		const int EVERYTHING_SORT_TYPE_NAME_DESCENDING = 10;
		const int EVERYTHING_SORT_DATE_CREATED_ASCENDING = 11;
		const int EVERYTHING_SORT_DATE_CREATED_DESCENDING = 12;
		const int EVERYTHING_SORT_DATE_MODIFIED_ASCENDING = 13;
		const int EVERYTHING_SORT_DATE_MODIFIED_DESCENDING = 14;
		const int EVERYTHING_SORT_ATTRIBUTES_ASCENDING = 15;
		const int EVERYTHING_SORT_ATTRIBUTES_DESCENDING = 16;
		const int EVERYTHING_SORT_FILE_LIST_FILENAME_ASCENDING = 17;
		const int EVERYTHING_SORT_FILE_LIST_FILENAME_DESCENDING = 18;
		const int EVERYTHING_SORT_RUN_COUNT_ASCENDING = 19;
		const int EVERYTHING_SORT_RUN_COUNT_DESCENDING = 20;
		const int EVERYTHING_SORT_DATE_RECENTLY_CHANGED_ASCENDING = 21;
		const int EVERYTHING_SORT_DATE_RECENTLY_CHANGED_DESCENDING = 22;
		const int EVERYTHING_SORT_DATE_ACCESSED_ASCENDING = 23;
		const int EVERYTHING_SORT_DATE_ACCESSED_DESCENDING= 24;
		const int EVERYTHING_SORT_DATE_RUN_ASCENDING = 25;
		const int EVERYTHING_SORT_DATE_RUN_DESCENDING = 26;

		const int EVERYTHING_TARGET_MACHINE_X86 = 1;
		const int EVERYTHING_TARGET_MACHINE_X64 = 2;
		const int EVERYTHING_TARGET_MACHINE_ARM = 3;

		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern UInt32 Everything_SetSearchW(string lpSearchString);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetMatchPath(bool bEnable);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetMatchCase(bool bEnable);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetMatchWholeWord(bool bEnable);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetRegex(bool bEnable);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetMax(UInt32 dwMax);
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetOffset(UInt32 dwOffset);

		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetMatchPath();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetMatchCase();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetMatchWholeWord();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetRegex();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetMax();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetOffset();
		[DllImport("Everything32.dll")]
		public static extern IntPtr Everything_GetSearchW();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetLastError();

		[DllImport("Everything32.dll")]
		public static extern bool Everything_QueryW(bool bWait);

		[DllImport("Everything32.dll")]
		public static extern void Everything_SortResultsByPath();

		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetNumFileResults();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetNumFolderResults();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetNumResults();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetTotFileResults();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetTotFolderResults();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetTotResults();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsVolumeResult(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsFolderResult(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsFileResult(UInt32 nIndex);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern void Everything_GetResultFullPathName(UInt32 nIndex, StringBuilder lpString, UInt32 nMaxCount);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultPath(UInt32 nIndex);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultFileName(UInt32 nIndex);

		[DllImport("Everything32.dll")]
		public static extern void Everything_Reset();
		[DllImport("Everything32.dll")]
		public static extern void Everything_CleanUp();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetMajorVersion();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetMinorVersion();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetRevision();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetBuildNumber();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_Exit();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsDBLoaded();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsAdmin();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_IsAppData();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_RebuildDB();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_UpdateAllFolderIndexes();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_SaveDB();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_SaveRunHistory();
		[DllImport("Everything32.dll")]
		public static extern bool Everything_DeleteRunHistory();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetTargetMachine();

		// Everything 1.4
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetSort(UInt32 dwSortType);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetSort();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetResultListSort();
		[DllImport("Everything32.dll")]
		public static extern void Everything_SetRequestFlags(UInt32 dwRequestFlags);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetRequestFlags();
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetResultListRequestFlags();
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultExtension(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultSize(UInt32 nIndex, out long lpFileSize);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultDateCreated(UInt32 nIndex, out long lpFileTime);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultDateModified(UInt32 nIndex, out long lpFileTime);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultDateAccessed(UInt32 nIndex, out long lpFileTime);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetResultAttributes(UInt32 nIndex);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultFileListFileName(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetResultRunCount(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultDateRun(UInt32 nIndex, out long lpFileTime);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_GetResultDateRecentlyChanged(UInt32 nIndex, out long lpFileTime);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultHighlightedFileName(UInt32 nIndex);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultHighlightedPath(UInt32 nIndex);
		[DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr Everything_GetResultHighlightedFullPathAndFileName(UInt32 nIndex);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_GetRunCountFromFileName(string lpFileName);
		[DllImport("Everything32.dll")]
		public static extern bool Everything_SetRunCountFromFileName(string lpFileName, UInt32 dwRunCount);
		[DllImport("Everything32.dll")]
		public static extern UInt32 Everything_IncRunCountFromFileName(string lpFileName);

		public Form1()
		{
			InitializeComponent();
            txtSavePath.Size = (groupBox4.Size - btnSelect.Size - label1.Size);
        }

		private void button1_Click(object sender, EventArgs e)
		{
            listBox1.Items.Clear();
   //         UInt32 i;

			//// set the search
			//Everything_SetSearchW(txtFileList.Text);

			//// use our own custom scrollbar... 			
			//// Everything_SetMax(listBox1.ClientRectangle.Height / listBox1.ItemHeight);
			//// Everything_SetOffset(VerticalScrollBarPosition...);

			//// request name and size
			//Everything_SetRequestFlags(EVERYTHING_REQUEST_FILE_NAME | EVERYTHING_REQUEST_PATH | EVERYTHING_REQUEST_DATE_MODIFIED | EVERYTHING_REQUEST_SIZE);

			//Everything_SetSort(13);

			//// execute the query
			//Everything_QueryW(true);

			//// sort by path
			//// Everything_SortResultsByPath();

			//// clear the old list of results			
			//listBox1.Items.Clear();

			//// set the window title
			//Text = txtFileList.Text + " - " + Everything_GetNumResults() + " Results";

			//// loop through the results, adding each result to the listbox.
			//for (i = 0; i < Everything_GetNumResults(); i++)
			//{
			//	long date_modified;
			//	long size;
   //             StringBuilder buf = new StringBuilder(bufsize);
   //             string strSrcPath = "";

			//	Everything_GetResultDateModified(i, out date_modified);
			//	Everything_GetResultSize(i, out size);
			//	Everything_GetResultFullPathName(i, buf, bufsize);
   //             strSrcPath= buf.ToString();

   //             // add it to the list box				
   //             listBox1.Items.Insert((int)i, "Path:"+ strSrcPath +";"+ "Size: " + size.ToString() + " Date Modified: " + DateTime.FromFileTime(date_modified).Year + "/" + DateTime.FromFileTime(date_modified).Month + "/" + DateTime.FromFileTime(date_modified).Day + " " + DateTime.FromFileTime(date_modified).Hour + ":" + DateTime.FromFileTime(date_modified).Minute.ToString("D2") + " Filename: " + Marshal.PtrToStringUni(Everything_GetResultFileName(i)));
			//}
		}

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSavePath.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strFileList = txtFileList.Text;
			if (strFileList.Length > 0)
			{
                string folderPath = txtSavePath.Text;
                if (Directory.Exists(folderPath))
				{
					string[] arr = strFileList.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
					pSearchFileCount = arr.Length;
					pSearchSuccessCount = 0;
					pCopySuccessCount = 0;
					int pTemp = 0;
                    listBox1.Items.Insert(listBox1.Items.Count, "==============================");
                    if (chbMatchWholeWord.Checked)
					{
						listBox1.Items.Insert(listBox1.Items.Count, "当前为精确查找模式");

                    }
					else 
					{
                        listBox1.Items.Insert(listBox1.Items.Count, "当前为模糊查找模式");
                    }
					listBox1.Items.Insert(listBox1.Items.Count, "任务开始，共计搜索" + pSearchFileCount + "个文件");
					if (pSearchFileCount > 0)
					{
						for (int i = 0; i < pSearchFileCount; i++)
						{
							pTemp = i + 1;
							listBox1.Items.Insert(listBox1.Items.Count, "开始查找第" + pTemp + "个文件,文件名为：" + arr[i]);
							Search(arr[i]);
							listBox1.Items.Insert(listBox1.Items.Count, "结束查找第" + pTemp + "个文件");

						}
					}
					listBox1.Items.Insert(listBox1.Items.Count, "任务结束，共计搜索"+ pSearchFileCount + "个文件，其中查找成功：" + pSearchSuccessCount + "个文件,复制成功：" + pCopySuccessCount + "个文件"); 
				}
				else 
				{
                    MessageBox.Show("保存路径不存在", "提醒");
                }
			}
			else
			{
				MessageBox.Show("搜索的文件清单不能为空","提醒");
			}
        }

        private void Search(string strFileName)
        {
            UInt32 i;

            // set the search
            Everything_SetSearchW(strFileName);
			Everything_SetMatchWholeWord(chbMatchWholeWord.Checked);

            // use our own custom scrollbar... 			
            // Everything_SetMax(listBox1.ClientRectangle.Height / listBox1.ItemHeight);
            // Everything_SetOffset(VerticalScrollBarPosition...);

            // request name and size
            Everything_SetRequestFlags(EVERYTHING_REQUEST_FILE_NAME | EVERYTHING_REQUEST_PATH | EVERYTHING_REQUEST_DATE_MODIFIED | EVERYTHING_REQUEST_SIZE);

            Everything_SetSort(13);

            // execute the query
            Everything_QueryW(true);

            // sort by path
            // Everything_SortResultsByPath();

            // clear the old list of results			
            //listBox1.Items.Clear();

            // set the window title
            //Text = txtFileList.Text + " - " + Everything_GetNumResults() + " Results";

            // loop through the results, adding each result to the listbox.
            listBox1.Items.Insert(listBox1.Items.Count, "此文件共计找到" + Everything_GetNumResults() + "个结果");
            for (i = 0; i < Everything_GetNumResults(); i++)
            {
				if (i==0)
				{
					pSearchSuccessCount++;
					long date_modified;
					long size;
					StringBuilder buf = new StringBuilder(bufsize);
					string strSrcPath = "";

					Everything_GetResultDateModified(i, out date_modified);
					Everything_GetResultSize(i, out size);
					Everything_GetResultFullPathName(i, buf, bufsize);
					strSrcPath = buf.ToString();
                    string dstFileName = txtSavePath.Text;
					string strFileName1 = Marshal.PtrToStringUni(Everything_GetResultFileName(i));
                    listBox1.Items.Insert(listBox1.Items.Count, "开始保存文件:"+ strFileName1);
                    CopyFileToDirectory(strSrcPath, dstFileName);
                    listBox1.Items.Insert(listBox1.Items.Count, "结束保存文件:"+ strFileName1);
                    // add it to the list box				
                    //listBox1.Items.Insert((int)i, "Path:" + strSrcPath + ";" + "Size: " + size.ToString() + " Date Modified: " + DateTime.FromFileTime(date_modified).Year + "/" + DateTime.FromFileTime(date_modified).Month + "/" + DateTime.FromFileTime(date_modified).Day + " " + DateTime.FromFileTime(date_modified).Hour + ":" + DateTime.FromFileTime(date_modified).Minute.ToString("D2") + " Filename: " + Marshal.PtrToStringUni(Everything_GetResultFileName(i))); 
				}
            }
        }

        private void CopyFileToDirectory(string sourceFilePath, string destinationDirectory)
        {
            // 确保目标文件夹存在
            Directory.CreateDirectory(destinationDirectory);

            // 获取源文件名
            string fileName = Path.GetFileName(sourceFilePath);

            // 目标文件路径
            string destinationFilePath = Path.Combine(destinationDirectory, fileName);

			// 复制文件
			try
			{
				File.Copy(sourceFilePath, destinationFilePath, true); // true 表示如果目标文件存在，则覆盖它
				pCopySuccessCount++;
			}
			catch (Exception e)
			{

				throw e;
			}
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_SizeChanged(object sender, EventArgs e)
        {
			txtSavePath.Size=(groupBox4.Size-btnSelect.Size-label1.Size);
        }

        private void btnReadme_Click(object sender, EventArgs e)
        {
			string strReadme = String.Format("本工具集成了Everything的SDK(版本 V1.4.1.1024)，用于全盘批量文件查找，并复制第一个匹配的结果到指定目录，使用前必须安装Everything。\r\n本工具仅限用于非商业用途，有任何问题和BUG请将就用吧，免费的，要啥自行车！！!点击“确定”访问Everything下载地址");
            DialogResult resault = MessageBox.Show(strReadme,"说明",MessageBoxButtons.OKCancel);
            if (resault == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.voidtools.com");
            }
        }
    }
}