using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C600 - .
/// </summary>
public class F43C600 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPCLSID.
        /// </summary>
        public const string CPCLSID = "CPCLSID";

        /// <summary>
        /// CPSEQN.
        /// </summary>
        public const string CPSEQN = "CPSEQN";

        /// <summary>
        /// CPCNTRTCLS.
        /// </summary>
        public const string CPCNTRTCLS = "CPCNTRTCLS";

        /// <summary>
        /// CPCLSACT.
        /// </summary>
        public const string CPCLSACT = "CPCLSACT";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPTORG.
        /// </summary>
        public const string CPTORG = "CPTORG";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUUPMJ.
        /// </summary>
        public const string CPUUPMJ = "CPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43C600";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPCLSID", "CPCLSID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPSEQN", "CPSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCNTRTCLS", "CPCNTRTCLS", JdeDataType.String, 20),
        new JdeField("CPCLSACT", "CPCLSACT", JdeDataType.String, 2),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPTORG", "CPTORG", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUUPMJ", "CPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C600_0", "Primary Key on CPCLSID, CPSEQN", new[] { "CPCLSID", "CPSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
