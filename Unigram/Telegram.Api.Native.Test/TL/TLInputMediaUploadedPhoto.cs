// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaUploadedPhoto : TLInputMediaBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Stickers = (1 << 0),
		}

		public bool HasStickers { get { return Flags.HasFlag(Flag.Stickers); } set { Flags = value ? (Flags | Flag.Stickers) : (Flags & ~Flag.Stickers); } }

		public Flag Flags { get; set; }
		public TLInputFileBase File { get; set; }
		public String Caption { get; set; }
		public TLVector<TLInputDocumentBase> Stickers { get; set; }

		public TLInputMediaUploadedPhoto() { }
		public TLInputMediaUploadedPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaUploadedPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			File = TLFactory.Read<TLInputFileBase>(from);
			Caption = from.ReadString();
			if (HasStickers) Stickers = TLFactory.Read<TLVector<TLInputDocumentBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteObject(File);
			to.WriteString(Caption ?? string.Empty);
			if (HasStickers) to.WriteObject(Stickers);
		}

		private void UpdateFlags()
		{
			HasStickers = Stickers != null;
		}
	}
}