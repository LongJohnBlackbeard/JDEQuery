using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B343 - .
/// </summary>
public class F31B343 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSBSDID.
        /// </summary>
        public const string BSBSDID = "BSBSDID";

        /// <summary>
        /// BSBATT1.
        /// </summary>
        public const string BSBATT1 = "BSBATT1";

        /// <summary>
        /// BSBATT2.
        /// </summary>
        public const string BSBATT2 = "BSBATT2";

        /// <summary>
        /// BSBATT3.
        /// </summary>
        public const string BSBATT3 = "BSBATT3";

        /// <summary>
        /// BSSDATA.
        /// </summary>
        public const string BSSDATA = "BSSDATA";

        /// <summary>
        /// BSSVALUE.
        /// </summary>
        public const string BSSVALUE = "BSSVALUE";

        /// <summary>
        /// BSSWEM.
        /// </summary>
        public const string BSSWEM = "BSSWEM";

        /// <summary>
        /// BSINSTYLE.
        /// </summary>
        public const string BSINSTYLE = "BSINSTYLE";

        /// <summary>
        /// BSSBMETH.
        /// </summary>
        public const string BSSBMETH = "BSSBMETH";

        /// <summary>
        /// BSSBVHC.
        /// </summary>
        public const string BSSBVHC = "BSSBVHC";

        /// <summary>
        /// BSSTVP.
        /// </summary>
        public const string BSSTVP = "BSSTVP";

        /// <summary>
        /// BSVBTSM.
        /// </summary>
        public const string BSVBTSM = "BSVBTSM";

        /// <summary>
        /// BSVBTBVHC.
        /// </summary>
        public const string BSVBTBVHC = "BSVBTBVHC";

        /// <summary>
        /// BSVBTSTP.
        /// </summary>
        public const string BSVBTSTP = "BSVBTSTP";

        /// <summary>
        /// BSURCD.
        /// </summary>
        public const string BSURCD = "BSURCD";

        /// <summary>
        /// BSURDT.
        /// </summary>
        public const string BSURDT = "BSURDT";

        /// <summary>
        /// BSURAT.
        /// </summary>
        public const string BSURAT = "BSURAT";

        /// <summary>
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSSTCC01.
        /// </summary>
        public const string BSSTCC01 = "BSSTCC01";

        /// <summary>
        /// BSSTCC02.
        /// </summary>
        public const string BSSTCC02 = "BSSTCC02";

        /// <summary>
        /// BSSTPFX.
        /// </summary>
        public const string BSSTPFX = "BSSTPFX";

        /// <summary>
        /// BSSTSFX.
        /// </summary>
        public const string BSSTSFX = "BSSTSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F31B343";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSBSDID", "BSBSDID", JdeDataType.Numeric, null, true, true),
        new JdeField("BSBATT1", "BSBATT1", JdeDataType.String, 10, true, true),
        new JdeField("BSBATT2", "BSBATT2", JdeDataType.String, 10, true, true),
        new JdeField("BSBATT3", "BSBATT3", JdeDataType.String, 10, true, true),
        new JdeField("BSSDATA", "BSSDATA", JdeDataType.String, 6),
        new JdeField("BSSVALUE", "BSSVALUE", JdeDataType.Numeric),
        new JdeField("BSSWEM", "BSSWEM", JdeDataType.String, 6),
        new JdeField("BSINSTYLE", "BSINSTYLE", JdeDataType.String, 2),
        new JdeField("BSSBMETH", "BSSBMETH", JdeDataType.String, 6),
        new JdeField("BSSBVHC", "BSSBVHC", JdeDataType.String, 6),
        new JdeField("BSSTVP", "BSSTVP", JdeDataType.Numeric),
        new JdeField("BSVBTSM", "BSVBTSM", JdeDataType.String, 6),
        new JdeField("BSVBTBVHC", "BSVBTBVHC", JdeDataType.String, 6),
        new JdeField("BSVBTSTP", "BSVBTSTP", JdeDataType.Numeric),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSSTCC01", "BSSTCC01", JdeDataType.String, 6),
        new JdeField("BSSTCC02", "BSSTCC02", JdeDataType.String, 6),
        new JdeField("BSSTPFX", "BSSTPFX", JdeDataType.String, 4, true, true),
        new JdeField("BSSTSFX", "BSSTSFX", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B343_0", "Primary Key on BSBSDID, BSBATT1, BSBATT2, BSBATT3, BSSTPFX, BSSTSFX", new[] { "BSBSDID", "BSBATT1", "BSBATT2", "BSBATT3", "BSSTPFX", "BSSTSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B343_2", "Index on BSBSDID", new[] { "BSBSDID" })
    };
}
