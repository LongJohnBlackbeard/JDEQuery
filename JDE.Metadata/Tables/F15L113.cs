using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L113 - .
/// </summary>
public class F15L113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SDRVNB.
        /// </summary>
        public const string SDRVNB = "SDRVNB";

        /// <summary>
        /// SDSOID.
        /// </summary>
        public const string SDSOID = "SDSOID";

        /// <summary>
        /// SDSOSQ.
        /// </summary>
        public const string SDSOSQ = "SDSOSQ";

        /// <summary>
        /// SDBKPT.
        /// </summary>
        public const string SDBKPT = "SDBKPT";

        /// <summary>
        /// SDBPSP.
        /// </summary>
        public const string SDBPSP = "SDBPSP";

        /// <summary>
        /// SDPRBK.
        /// </summary>
        public const string SDPRBK = "SDPRBK";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDTORG.
        /// </summary>
        public const string SDTORG = "SDTORG";

        /// <summary>
        /// SDENTJ.
        /// </summary>
        public const string SDENTJ = "SDENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24, true, true),
        new JdeField("SDRVNB", "SDRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSOID", "SDSOID", JdeDataType.String, 20, true, true),
        new JdeField("SDSOSQ", "SDSOSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SDBKPT", "SDBKPT", JdeDataType.Numeric),
        new JdeField("SDBPSP", "SDBPSP", JdeDataType.Numeric),
        new JdeField("SDPRBK", "SDPRBK", JdeDataType.String, 2),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDTORG", "SDTORG", JdeDataType.String, 20),
        new JdeField("SDENTJ", "SDENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L113_0", "Primary Key on SDMCU, SDRVNB, SDSOID, SDSOSQ", new[] { "SDMCU", "SDRVNB", "SDSOID", "SDSOSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
