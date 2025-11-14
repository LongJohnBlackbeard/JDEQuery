using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G003 - .
/// </summary>
public class F40G003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HPHARPAT.
        /// </summary>
        public const string HPHARPAT = "HPHARPAT";

        /// <summary>
        /// HPHARPER.
        /// </summary>
        public const string HPHARPER = "HPHARPER";

        /// <summary>
        /// HPCURPER.
        /// </summary>
        public const string HPCURPER = "HPCURPER";

        /// <summary>
        /// HPHARVSD.
        /// </summary>
        public const string HPHARVSD = "HPHARVSD";

        /// <summary>
        /// HPHARVED.
        /// </summary>
        public const string HPHARVED = "HPHARVED";

        /// <summary>
        /// HPDL01.
        /// </summary>
        public const string HPDL01 = "HPDL01";

        /// <summary>
        /// HPURCD.
        /// </summary>
        public const string HPURCD = "HPURCD";

        /// <summary>
        /// HPURDT.
        /// </summary>
        public const string HPURDT = "HPURDT";

        /// <summary>
        /// HPURRF.
        /// </summary>
        public const string HPURRF = "HPURRF";

        /// <summary>
        /// HPURAB.
        /// </summary>
        public const string HPURAB = "HPURAB";

        /// <summary>
        /// HPURAT.
        /// </summary>
        public const string HPURAT = "HPURAT";

        /// <summary>
        /// HPTORG.
        /// </summary>
        public const string HPTORG = "HPTORG";

        /// <summary>
        /// HPUSER.
        /// </summary>
        public const string HPUSER = "HPUSER";

        /// <summary>
        /// HPPID.
        /// </summary>
        public const string HPPID = "HPPID";

        /// <summary>
        /// HPJOBN.
        /// </summary>
        public const string HPJOBN = "HPJOBN";

        /// <summary>
        /// HPUUPMJ.
        /// </summary>
        public const string HPUUPMJ = "HPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HPHARPAT", "HPHARPAT", JdeDataType.String, 20, true, true),
        new JdeField("HPHARPER", "HPHARPER", JdeDataType.String, 12, true, true),
        new JdeField("HPCURPER", "HPCURPER", JdeDataType.String, 2),
        new JdeField("HPHARVSD", "HPHARVSD", JdeDataType.Date),
        new JdeField("HPHARVED", "HPHARVED", JdeDataType.Date),
        new JdeField("HPDL01", "HPDL01", JdeDataType.String, 60),
        new JdeField("HPURCD", "HPURCD", JdeDataType.String, 4),
        new JdeField("HPURDT", "HPURDT", JdeDataType.Numeric),
        new JdeField("HPURRF", "HPURRF", JdeDataType.String, 30),
        new JdeField("HPURAB", "HPURAB", JdeDataType.Numeric),
        new JdeField("HPURAT", "HPURAT", JdeDataType.Numeric),
        new JdeField("HPTORG", "HPTORG", JdeDataType.String, 20),
        new JdeField("HPUSER", "HPUSER", JdeDataType.String, 20),
        new JdeField("HPPID", "HPPID", JdeDataType.String, 20),
        new JdeField("HPJOBN", "HPJOBN", JdeDataType.String, 20),
        new JdeField("HPUUPMJ", "HPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G003_0", "Primary Key on HPHARPAT, HPHARPER", new[] { "HPHARPAT", "HPHARPER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G003_2", "Index on HPHARPAT, HPHARVSD", new[] { "HPHARPAT", "HPHARVSD" }),
        new JdeIndex("F40G003_3", "Index on HPHARPAT, HPHARPER, HPCURPER", new[] { "HPHARPAT", "HPHARPER", "HPCURPER" }),
        new JdeIndex("F40G003_4", "Index on HPHARPER", new[] { "HPHARPER" })
    };
}
