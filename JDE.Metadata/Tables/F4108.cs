using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4108 - .
/// </summary>
public class F4108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IOLOTN.
        /// </summary>
        public const string IOLOTN = "IOLOTN";

        /// <summary>
        /// IOLDSC.
        /// </summary>
        public const string IOLDSC = "IOLDSC";

        /// <summary>
        /// IOLOTS.
        /// </summary>
        public const string IOLOTS = "IOLOTS";

        /// <summary>
        /// IOMCU.
        /// </summary>
        public const string IOMCU = "IOMCU";

        /// <summary>
        /// IOITM.
        /// </summary>
        public const string IOITM = "IOITM";

        /// <summary>
        /// IOLITM.
        /// </summary>
        public const string IOLITM = "IOLITM";

        /// <summary>
        /// IOAITM.
        /// </summary>
        public const string IOAITM = "IOAITM";

        /// <summary>
        /// IOVEND.
        /// </summary>
        public const string IOVEND = "IOVEND";

        /// <summary>
        /// IOKCOO.
        /// </summary>
        public const string IOKCOO = "IOKCOO";

        /// <summary>
        /// IODOCO.
        /// </summary>
        public const string IODOCO = "IODOCO";

        /// <summary>
        /// IODCTO.
        /// </summary>
        public const string IODCTO = "IODCTO";

        /// <summary>
        /// IORLOT.
        /// </summary>
        public const string IORLOT = "IORLOT";

        /// <summary>
        /// IOLOTP.
        /// </summary>
        public const string IOLOTP = "IOLOTP";

        /// <summary>
        /// IOLOTG.
        /// </summary>
        public const string IOLOTG = "IOLOTG";

        /// <summary>
        /// IOMMEJ.
        /// </summary>
        public const string IOMMEJ = "IOMMEJ";

        /// <summary>
        /// IOSERN.
        /// </summary>
        public const string IOSERN = "IOSERN";

        /// <summary>
        /// IOUA01.
        /// </summary>
        public const string IOUA01 = "IOUA01";

        /// <summary>
        /// IOUA02.
        /// </summary>
        public const string IOUA02 = "IOUA02";

        /// <summary>
        /// IOUA03.
        /// </summary>
        public const string IOUA03 = "IOUA03";

        /// <summary>
        /// IOUA04.
        /// </summary>
        public const string IOUA04 = "IOUA04";

        /// <summary>
        /// IOUA05.
        /// </summary>
        public const string IOUA05 = "IOUA05";

        /// <summary>
        /// IOUA06.
        /// </summary>
        public const string IOUA06 = "IOUA06";

        /// <summary>
        /// IOUB01.
        /// </summary>
        public const string IOUB01 = "IOUB01";

        /// <summary>
        /// IOUB02.
        /// </summary>
        public const string IOUB02 = "IOUB02";

        /// <summary>
        /// IOUB03.
        /// </summary>
        public const string IOUB03 = "IOUB03";

        /// <summary>
        /// IOUB04.
        /// </summary>
        public const string IOUB04 = "IOUB04";

        /// <summary>
        /// IOUB05.
        /// </summary>
        public const string IOUB05 = "IOUB05";

        /// <summary>
        /// IOUB06.
        /// </summary>
        public const string IOUB06 = "IOUB06";

        /// <summary>
        /// IOUSER.
        /// </summary>
        public const string IOUSER = "IOUSER";

        /// <summary>
        /// IOPID.
        /// </summary>
        public const string IOPID = "IOPID";

        /// <summary>
        /// IOUPMJ.
        /// </summary>
        public const string IOUPMJ = "IOUPMJ";

        /// <summary>
        /// IOTDAY.
        /// </summary>
        public const string IOTDAY = "IOTDAY";

        /// <summary>
        /// IOJOBN.
        /// </summary>
        public const string IOJOBN = "IOJOBN";

        /// <summary>
        /// IOLRP1.
        /// </summary>
        public const string IOLRP1 = "IOLRP1";

        /// <summary>
        /// IOLRP2.
        /// </summary>
        public const string IOLRP2 = "IOLRP2";

        /// <summary>
        /// IOLRP3.
        /// </summary>
        public const string IOLRP3 = "IOLRP3";

        /// <summary>
        /// IOLRP4.
        /// </summary>
        public const string IOLRP4 = "IOLRP4";

        /// <summary>
        /// IOLRP5.
        /// </summary>
        public const string IOLRP5 = "IOLRP5";

        /// <summary>
        /// IOLRP6.
        /// </summary>
        public const string IOLRP6 = "IOLRP6";

        /// <summary>
        /// IOLRP7.
        /// </summary>
        public const string IOLRP7 = "IOLRP7";

        /// <summary>
        /// IOLRP8.
        /// </summary>
        public const string IOLRP8 = "IOLRP8";

        /// <summary>
        /// IOLRP9.
        /// </summary>
        public const string IOLRP9 = "IOLRP9";

        /// <summary>
        /// IOLRP0.
        /// </summary>
        public const string IOLRP0 = "IOLRP0";

        /// <summary>
        /// IOLOT1.
        /// </summary>
        public const string IOLOT1 = "IOLOT1";

        /// <summary>
        /// IOLOT2.
        /// </summary>
        public const string IOLOT2 = "IOLOT2";

        /// <summary>
        /// IOLOT3.
        /// </summary>
        public const string IOLOT3 = "IOLOT3";

        /// <summary>
        /// IOBBDJ.
        /// </summary>
        public const string IOBBDJ = "IOBBDJ";

        /// <summary>
        /// IOBODJ.
        /// </summary>
        public const string IOBODJ = "IOBODJ";

        /// <summary>
        /// IODLEJ.
        /// </summary>
        public const string IODLEJ = "IODLEJ";

        /// <summary>
        /// IOOHDJ.
        /// </summary>
        public const string IOOHDJ = "IOOHDJ";

        /// <summary>
        /// IOSBDJ.
        /// </summary>
        public const string IOSBDJ = "IOSBDJ";

        /// <summary>
        /// IOU1DJ.
        /// </summary>
        public const string IOU1DJ = "IOU1DJ";

        /// <summary>
        /// IOU2DJ.
        /// </summary>
        public const string IOU2DJ = "IOU2DJ";

        /// <summary>
        /// IOU3DJ.
        /// </summary>
        public const string IOU3DJ = "IOU3DJ";

        /// <summary>
        /// IOU4DJ.
        /// </summary>
        public const string IOU4DJ = "IOU4DJ";

        /// <summary>
        /// IOU5DJ.
        /// </summary>
        public const string IOU5DJ = "IOU5DJ";

        /// <summary>
        /// IOCHDF.
        /// </summary>
        public const string IOCHDF = "IOCHDF";

        /// <summary>
        /// IOWPDF.
        /// </summary>
        public const string IOWPDF = "IOWPDF";

        /// <summary>
        /// IODOC1.
        /// </summary>
        public const string IODOC1 = "IODOC1";

        /// <summary>
        /// IOLOTR.
        /// </summary>
        public const string IOLOTR = "IOLOTR";

        /// <summary>
        /// IOLOTC.
        /// </summary>
        public const string IOLOTC = "IOLOTC";

        /// <summary>
        /// IOORIG.
        /// </summary>
        public const string IOORIG = "IOORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F4108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IOLOTN", "IOLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IOLDSC", "IOLDSC", JdeDataType.String, 60),
        new JdeField("IOLOTS", "IOLOTS", JdeDataType.String, 2),
        new JdeField("IOMCU", "IOMCU", JdeDataType.String, 24, true, true),
        new JdeField("IOITM", "IOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IOLITM", "IOLITM", JdeDataType.String, 50),
        new JdeField("IOAITM", "IOAITM", JdeDataType.String, 50),
        new JdeField("IOVEND", "IOVEND", JdeDataType.Numeric),
        new JdeField("IOKCOO", "IOKCOO", JdeDataType.String, 10),
        new JdeField("IODOCO", "IODOCO", JdeDataType.Numeric),
        new JdeField("IODCTO", "IODCTO", JdeDataType.String, 4),
        new JdeField("IORLOT", "IORLOT", JdeDataType.String, 60),
        new JdeField("IOLOTP", "IOLOTP", JdeDataType.Numeric),
        new JdeField("IOLOTG", "IOLOTG", JdeDataType.String, 6),
        new JdeField("IOMMEJ", "IOMMEJ", JdeDataType.Numeric),
        new JdeField("IOSERN", "IOSERN", JdeDataType.String, 60),
        new JdeField("IOUA01", "IOUA01", JdeDataType.Numeric),
        new JdeField("IOUA02", "IOUA02", JdeDataType.Numeric),
        new JdeField("IOUA03", "IOUA03", JdeDataType.Numeric),
        new JdeField("IOUA04", "IOUA04", JdeDataType.Numeric),
        new JdeField("IOUA05", "IOUA05", JdeDataType.Numeric),
        new JdeField("IOUA06", "IOUA06", JdeDataType.Numeric),
        new JdeField("IOUB01", "IOUB01", JdeDataType.Numeric),
        new JdeField("IOUB02", "IOUB02", JdeDataType.Numeric),
        new JdeField("IOUB03", "IOUB03", JdeDataType.Numeric),
        new JdeField("IOUB04", "IOUB04", JdeDataType.Numeric),
        new JdeField("IOUB05", "IOUB05", JdeDataType.Numeric),
        new JdeField("IOUB06", "IOUB06", JdeDataType.Numeric),
        new JdeField("IOUSER", "IOUSER", JdeDataType.String, 20),
        new JdeField("IOPID", "IOPID", JdeDataType.String, 20),
        new JdeField("IOUPMJ", "IOUPMJ", JdeDataType.Numeric),
        new JdeField("IOTDAY", "IOTDAY", JdeDataType.Numeric),
        new JdeField("IOJOBN", "IOJOBN", JdeDataType.String, 20),
        new JdeField("IOLRP1", "IOLRP1", JdeDataType.String, 6),
        new JdeField("IOLRP2", "IOLRP2", JdeDataType.String, 6),
        new JdeField("IOLRP3", "IOLRP3", JdeDataType.String, 6),
        new JdeField("IOLRP4", "IOLRP4", JdeDataType.String, 6),
        new JdeField("IOLRP5", "IOLRP5", JdeDataType.String, 6),
        new JdeField("IOLRP6", "IOLRP6", JdeDataType.String, 6),
        new JdeField("IOLRP7", "IOLRP7", JdeDataType.String, 6),
        new JdeField("IOLRP8", "IOLRP8", JdeDataType.String, 6),
        new JdeField("IOLRP9", "IOLRP9", JdeDataType.String, 6),
        new JdeField("IOLRP0", "IOLRP0", JdeDataType.String, 6),
        new JdeField("IOLOT1", "IOLOT1", JdeDataType.String, 60),
        new JdeField("IOLOT2", "IOLOT2", JdeDataType.String, 60),
        new JdeField("IOLOT3", "IOLOT3", JdeDataType.String, 60),
        new JdeField("IOBBDJ", "IOBBDJ", JdeDataType.Numeric),
        new JdeField("IOBODJ", "IOBODJ", JdeDataType.Numeric),
        new JdeField("IODLEJ", "IODLEJ", JdeDataType.Numeric),
        new JdeField("IOOHDJ", "IOOHDJ", JdeDataType.Numeric),
        new JdeField("IOSBDJ", "IOSBDJ", JdeDataType.Numeric),
        new JdeField("IOU1DJ", "IOU1DJ", JdeDataType.Numeric),
        new JdeField("IOU2DJ", "IOU2DJ", JdeDataType.Numeric),
        new JdeField("IOU3DJ", "IOU3DJ", JdeDataType.Numeric),
        new JdeField("IOU4DJ", "IOU4DJ", JdeDataType.Numeric),
        new JdeField("IOU5DJ", "IOU5DJ", JdeDataType.Numeric),
        new JdeField("IOCHDF", "IOCHDF", JdeDataType.String, 2),
        new JdeField("IOWPDF", "IOWPDF", JdeDataType.String, 2),
        new JdeField("IODOC1", "IODOC1", JdeDataType.Numeric),
        new JdeField("IOLOTR", "IOLOTR", JdeDataType.String, 2),
        new JdeField("IOLOTC", "IOLOTC", JdeDataType.String, 6),
        new JdeField("IOORIG", "IOORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4108_0", "Primary Key on IOLOTN, IOITM, IOMCU", new[] { "IOLOTN", "IOITM", "IOMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4108_2", "Index on IOITM, IOMCU, IOLOTN", new[] { "IOITM", "IOMCU", "IOLOTN" }),
        new JdeIndex("F4108_3", "Index on IORLOT, IOMCU, IOLOTN", new[] { "IORLOT", "IOMCU", "IOLOTN" }),
        new JdeIndex("F4108_4", "Index on IOITM, IOMCU, IOMMEJ", new[] { "IOITM", "IOMCU", "IOMMEJ" }),
        new JdeIndex("F4108_5", "Index on IOLOTN, IOMCU, IOITM", new[] { "IOLOTN", "IOMCU", "IOITM" }),
        new JdeIndex("F4108_6", "Index on IODOC1", new[] { "IODOC1" }),
        new JdeIndex("F4108_7", "Index on IOLOT2, IOLOT1, IOVEND", new[] { "IOLOT2", "IOLOT1", "IOVEND" })
    };
}
