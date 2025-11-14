using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H592 - .
/// </summary>
public class F44H592 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMCWTMPT.
        /// </summary>
        public const string EMCWTMPT = "EMCWTMPT";

        /// <summary>
        /// EMSDTYP.
        /// </summary>
        public const string EMSDTYP = "EMSDTYP";

        /// <summary>
        /// EMSDKY.
        /// </summary>
        public const string EMSDKY = "EMSDKY";

        /// <summary>
        /// EMHBAREA.
        /// </summary>
        public const string EMHBAREA = "EMHBAREA";

        /// <summary>
        /// EMHBMCUS.
        /// </summary>
        public const string EMHBMCUS = "EMHBMCUS";

        /// <summary>
        /// EMSDLIN.
        /// </summary>
        public const string EMSDLIN = "EMSDLIN";

        /// <summary>
        /// EMCLDATA.
        /// </summary>
        public const string EMCLDATA = "EMCLDATA";

        /// <summary>
        /// EMCLSRT.
        /// </summary>
        public const string EMCLSRT = "EMCLSRT";

        /// <summary>
        /// EMCRTU.
        /// </summary>
        public const string EMCRTU = "EMCRTU";

        /// <summary>
        /// EMCRTJ.
        /// </summary>
        public const string EMCRTJ = "EMCRTJ";

        /// <summary>
        /// EMCRTT.
        /// </summary>
        public const string EMCRTT = "EMCRTT";

        /// <summary>
        /// EMWRKSTNID.
        /// </summary>
        public const string EMWRKSTNID = "EMWRKSTNID";

        /// <summary>
        /// EMHBOPID.
        /// </summary>
        public const string EMHBOPID = "EMHBOPID";

        /// <summary>
        /// EMUPMB.
        /// </summary>
        public const string EMUPMB = "EMUPMB";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H592";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMCWTMPT", "EMCWTMPT", JdeDataType.String, 24, true, true),
        new JdeField("EMSDTYP", "EMSDTYP", JdeDataType.String, 6, true, true),
        new JdeField("EMSDKY", "EMSDKY", JdeDataType.String, 20, true, true),
        new JdeField("EMHBAREA", "EMHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("EMHBMCUS", "EMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("EMSDLIN", "EMSDLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("EMCLDATA", "EMCLDATA", JdeDataType.String, 20, true, true),
        new JdeField("EMCLSRT", "EMCLSRT", JdeDataType.Numeric),
        new JdeField("EMCRTU", "EMCRTU", JdeDataType.String, 20),
        new JdeField("EMCRTJ", "EMCRTJ", JdeDataType.Numeric),
        new JdeField("EMCRTT", "EMCRTT", JdeDataType.Numeric),
        new JdeField("EMWRKSTNID", "EMWRKSTNID", JdeDataType.String, 20),
        new JdeField("EMHBOPID", "EMHBOPID", JdeDataType.String, 20),
        new JdeField("EMUPMB", "EMUPMB", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H592_0", "Primary Key on EMCWTMPT, EMSDTYP, EMSDKY, EMHBAREA, EMHBMCUS, EMSDLIN, EMCLDATA", new[] { "EMCWTMPT", "EMSDTYP", "EMSDKY", "EMHBAREA", "EMHBMCUS", "EMSDLIN", "EMCLDATA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H592_2", "Index on EMCWTMPT, EMCLSRT, EMHBMCUS", new[] { "EMCWTMPT", "EMCLSRT", "EMHBMCUS" })
    };
}
