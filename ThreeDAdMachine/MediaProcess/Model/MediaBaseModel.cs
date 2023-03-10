using System.IO;
using System.Windows;

namespace MediaProcess.Model
{
    public abstract class MediaBaseModel
    {
        #region Constructor


        #endregion

        #region Property

        public string Path { get; set; }

        public string Name => System.IO.Path.GetFileName(Path);

        public long FileSize => new FileInfo(Path).Length;

        public DataModel DataModel { get; set; }

        public PlaySettingModel PlaySettingModel { get; set; }

        public virtual Size FrameSize { get; protected set; }

        #endregion

        public override string ToString() => Name;
    }
}
