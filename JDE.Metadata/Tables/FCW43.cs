using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW43 - .
/// </summary>
public class FCW43 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MOC9CMRL.
        /// </summary>
        public const string MOC9CMRL = "MOC9CMRL";

        /// <summary>
        /// MOJD.
        /// </summary>
        public const string MOJD = "MOJD";

        /// <summary>
        /// MOC9DATCR.
        /// </summary>
        public const string MOC9DATCR = "MOC9DATCR";

        /// <summary>
        /// MOC9DATEX.
        /// </summary>
        public const string MOC9DATEX = "MOC9DATEX";

        /// <summary>
        /// MOC9DATVEX.
        /// </summary>
        public const string MOC9DATVEX = "MOC9DATVEX";

        /// <summary>
        /// MOC9QTYP.
        /// </summary>
        public const string MOC9QTYP = "MOC9QTYP";

        /// <summary>
        /// MOC9NBOP.
        /// </summary>
        public const string MOC9NBOP = "MOC9NBOP";

        /// <summary>
        /// MOC9QTYR.
        /// </summary>
        public const string MOC9QTYR = "MOC9QTYR";

        /// <summary>
        /// MOC9NBOR.
        /// </summary>
        public const string MOC9NBOR = "MOC9NBOR";

        /// <summary>
        /// MOC9PARR.
        /// </summary>
        public const string MOC9PARR = "MOC9PARR";

        /// <summary>
        /// MOC9PORR.
        /// </summary>
        public const string MOC9PORR = "MOC9PORR";

        /// <summary>
        /// MOC9STEX.
        /// </summary>
        public const string MOC9STEX = "MOC9STEX";

        /// <summary>
        /// MOUSER.
        /// </summary>
        public const string MOUSER = "MOUSER";

        /// <summary>
        /// MOPID.
        /// </summary>
        public const string MOPID = "MOPID";

        /// <summary>
        /// MOUPMJ.
        /// </summary>
        public const string MOUPMJ = "MOUPMJ";

        /// <summary>
        /// MOJOBN.
        /// </summary>
        public const string MOJOBN = "MOJOBN";

        /// <summary>
        /// MOUPMT.
        /// </summary>
        public const string MOUPMT = "MOUPMT";

        /// <summary>
        /// MOC9TYTT.
        /// </summary>
        public const string MOC9TYTT = "MOC9TYTT";

        /// <summary>
        /// MOC9NXTRF.
        /// </summary>
        public const string MOC9NXTRF = "MOC9NXTRF";

        /// <summary>
        /// MOC9NXTRT.
        /// </summary>
        public const string MOC9NXTRT = "MOC9NXTRT";

        /// <summary>
        /// MOC9NXTR.
        /// </summary>
        public const string MOC9NXTR = "MOC9NXTR";

        /// <summary>
        /// MOTRDJ.
        /// </summary>
        public const string MOTRDJ = "MOTRDJ";

        /// <summary>
        /// MORSDJ.
        /// </summary>
        public const string MORSDJ = "MORSDJ";

        /// <summary>
        /// MODATE01.
        /// </summary>
        public const string MODATE01 = "MODATE01";

        /// <summary>
        /// MOC9SBCE.
        /// </summary>
        public const string MOC9SBCE = "MOC9SBCE";

        /// <summary>
        /// MOC9RATE1.
        /// </summary>
        public const string MOC9RATE1 = "MOC9RATE1";

        /// <summary>
        /// MOC9QTY1.
        /// </summary>
        public const string MOC9QTY1 = "MOC9QTY1";

        /// <summary>
        /// MOC9QTY2.
        /// </summary>
        public const string MOC9QTY2 = "MOC9QTY2";

        /// <summary>
        /// MOC9QTY3.
        /// </summary>
        public const string MOC9QTY3 = "MOC9QTY3";

        /// <summary>
        /// MOC9RATE2.
        /// </summary>
        public const string MOC9RATE2 = "MOC9RATE2";

        /// <summary>
        /// MOC9MXLN1.
        /// </summary>
        public const string MOC9MXLN1 = "MOC9MXLN1";

        /// <summary>
        /// MOC9MXLN2.
        /// </summary>
        public const string MOC9MXLN2 = "MOC9MXLN2";

        /// <summary>
        /// MOC9MXLN3.
        /// </summary>
        public const string MOC9MXLN3 = "MOC9MXLN3";

        /// <summary>
        /// MOC9MXLN4.
        /// </summary>
        public const string MOC9MXLN4 = "MOC9MXLN4";

        /// <summary>
        /// MOC9MXLN5.
        /// </summary>
        public const string MOC9MXLN5 = "MOC9MXLN5";

        /// <summary>
        /// MOC9MXLN6.
        /// </summary>
        public const string MOC9MXLN6 = "MOC9MXLN6";

        /// <summary>
        /// MOC9MXLN7.
        /// </summary>
        public const string MOC9MXLN7 = "MOC9MXLN7";

        /// <summary>
        /// MOC9MXLN8.
        /// </summary>
        public const string MOC9MXLN8 = "MOC9MXLN8";

        /// <summary>
        /// MOC9RATE3.
        /// </summary>
        public const string MOC9RATE3 = "MOC9RATE3";

        /// <summary>
        /// MOC9RATE4.
        /// </summary>
        public const string MOC9RATE4 = "MOC9RATE4";

        /// <summary>
        /// MOC9RATE5.
        /// </summary>
        public const string MOC9RATE5 = "MOC9RATE5";

        /// <summary>
        /// MOC9RATE6.
        /// </summary>
        public const string MOC9RATE6 = "MOC9RATE6";

        /// <summary>
        /// MOC9RATE7.
        /// </summary>
        public const string MOC9RATE7 = "MOC9RATE7";

        /// <summary>
        /// MOC9RATE8.
        /// </summary>
        public const string MOC9RATE8 = "MOC9RATE8";

        /// <summary>
        /// MOC9CMR.
        /// </summary>
        public const string MOC9CMR = "MOC9CMR";

        /// <summary>
        /// MOC9MXLN9.
        /// </summary>
        public const string MOC9MXLN9 = "MOC9MXLN9";

        /// <summary>
        /// MOC9SRP.
        /// </summary>
        public const string MOC9SRP = "MOC9SRP";

        /// <summary>
        /// MOC9SRP1.
        /// </summary>
        public const string MOC9SRP1 = "MOC9SRP1";

        /// <summary>
        /// MOC9RATE9.
        /// </summary>
        public const string MOC9RATE9 = "MOC9RATE9";
    }

    /// <inheritdoc />
    public override string TableName => "FCW43";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MOC9CMRL", "MOC9CMRL", JdeDataType.String, 20, true, true),
        new JdeField("MOJD", "MOJD", JdeDataType.String, 100),
        new JdeField("MOC9DATCR", "MOC9DATCR", JdeDataType.Numeric),
        new JdeField("MOC9DATEX", "MOC9DATEX", JdeDataType.Numeric),
        new JdeField("MOC9DATVEX", "MOC9DATVEX", JdeDataType.Numeric),
        new JdeField("MOC9QTYP", "MOC9QTYP", JdeDataType.Numeric),
        new JdeField("MOC9NBOP", "MOC9NBOP", JdeDataType.Numeric),
        new JdeField("MOC9QTYR", "MOC9QTYR", JdeDataType.Numeric),
        new JdeField("MOC9NBOR", "MOC9NBOR", JdeDataType.Numeric),
        new JdeField("MOC9PARR", "MOC9PARR", JdeDataType.Numeric),
        new JdeField("MOC9PORR", "MOC9PORR", JdeDataType.Numeric),
        new JdeField("MOC9STEX", "MOC9STEX", JdeDataType.String, 6),
        new JdeField("MOUSER", "MOUSER", JdeDataType.String, 20),
        new JdeField("MOPID", "MOPID", JdeDataType.String, 20),
        new JdeField("MOUPMJ", "MOUPMJ", JdeDataType.Numeric),
        new JdeField("MOJOBN", "MOJOBN", JdeDataType.String, 20),
        new JdeField("MOUPMT", "MOUPMT", JdeDataType.Numeric),
        new JdeField("MOC9TYTT", "MOC9TYTT", JdeDataType.String, 2),
        new JdeField("MOC9NXTRF", "MOC9NXTRF", JdeDataType.String, 6),
        new JdeField("MOC9NXTRT", "MOC9NXTRT", JdeDataType.String, 6),
        new JdeField("MOC9NXTR", "MOC9NXTR", JdeDataType.String, 6),
        new JdeField("MOTRDJ", "MOTRDJ", JdeDataType.Numeric),
        new JdeField("MORSDJ", "MORSDJ", JdeDataType.Numeric),
        new JdeField("MODATE01", "MODATE01", JdeDataType.Numeric),
        new JdeField("MOC9SBCE", "MOC9SBCE", JdeDataType.String, 2),
        new JdeField("MOC9RATE1", "MOC9RATE1", JdeDataType.Numeric),
        new JdeField("MOC9QTY1", "MOC9QTY1", JdeDataType.Numeric),
        new JdeField("MOC9QTY2", "MOC9QTY2", JdeDataType.Numeric),
        new JdeField("MOC9QTY3", "MOC9QTY3", JdeDataType.Numeric),
        new JdeField("MOC9RATE2", "MOC9RATE2", JdeDataType.Numeric),
        new JdeField("MOC9MXLN1", "MOC9MXLN1", JdeDataType.String, 2),
        new JdeField("MOC9MXLN2", "MOC9MXLN2", JdeDataType.String, 2),
        new JdeField("MOC9MXLN3", "MOC9MXLN3", JdeDataType.String, 2),
        new JdeField("MOC9MXLN4", "MOC9MXLN4", JdeDataType.String, 2),
        new JdeField("MOC9MXLN5", "MOC9MXLN5", JdeDataType.String, 2),
        new JdeField("MOC9MXLN6", "MOC9MXLN6", JdeDataType.String, 2),
        new JdeField("MOC9MXLN7", "MOC9MXLN7", JdeDataType.String, 2),
        new JdeField("MOC9MXLN8", "MOC9MXLN8", JdeDataType.String, 2),
        new JdeField("MOC9RATE3", "MOC9RATE3", JdeDataType.Numeric),
        new JdeField("MOC9RATE4", "MOC9RATE4", JdeDataType.Numeric),
        new JdeField("MOC9RATE5", "MOC9RATE5", JdeDataType.Numeric),
        new JdeField("MOC9RATE6", "MOC9RATE6", JdeDataType.Numeric),
        new JdeField("MOC9RATE7", "MOC9RATE7", JdeDataType.Numeric),
        new JdeField("MOC9RATE8", "MOC9RATE8", JdeDataType.Numeric),
        new JdeField("MOC9CMR", "MOC9CMR", JdeDataType.String, 20),
        new JdeField("MOC9MXLN9", "MOC9MXLN9", JdeDataType.String, 2),
        new JdeField("MOC9SRP", "MOC9SRP", JdeDataType.String, 20),
        new JdeField("MOC9SRP1", "MOC9SRP1", JdeDataType.String, 20),
        new JdeField("MOC9RATE9", "MOC9RATE9", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW43_0", "Primary Key on MOC9CMRL", new[] { "MOC9CMRL" }, isUnique: true, isPrimaryKey: true)
    };
}
