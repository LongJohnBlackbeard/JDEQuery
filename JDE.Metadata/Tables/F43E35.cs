using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E35 - .
/// </summary>
public class F43E35 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPXMLSCH.
        /// </summary>
        public const string CPXMLSCH = "CPXMLSCH";

        /// <summary>
        /// CPHTTPSERV.
        /// </summary>
        public const string CPHTTPSERV = "CPHTTPSERV";

        /// <summary>
        /// CPBSSVCLSS.
        /// </summary>
        public const string CPBSSVCLSS = "CPBSSVCLSS";

        /// <summary>
        /// CPBSSVMTHD.
        /// </summary>
        public const string CPBSSVMTHD = "CPBSSVMTHD";

        /// <summary>
        /// CPXSLTRAN.
        /// </summary>
        public const string CPXSLTRAN = "CPXSLTRAN";

        /// <summary>
        /// CPDOCVERS.
        /// </summary>
        public const string CPDOCVERS = "CPDOCVERS";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

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
    public override string TableName => "F43E35";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPXMLSCH", "CPXMLSCH", JdeDataType.String, 60, true, true),
        new JdeField("CPHTTPSERV", "CPHTTPSERV", JdeDataType.String, 4, true, true),
        new JdeField("CPBSSVCLSS", "CPBSSVCLSS", JdeDataType.String, 512),
        new JdeField("CPBSSVMTHD", "CPBSSVMTHD", JdeDataType.String, 512),
        new JdeField("CPXSLTRAN", "CPXSLTRAN", JdeDataType.String, 512),
        new JdeField("CPDOCVERS", "CPDOCVERS", JdeDataType.String, 512),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPTORG", "CPTORG", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUUPMJ", "CPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E35_0", "Primary Key on CPXMLSCH, CPHTTPSERV", new[] { "CPXMLSCH", "CPHTTPSERV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E35_2", "Index on CPHTTPSERV, CPXMLSCH", new[] { "CPHTTPSERV", "CPXMLSCH" })
    };
}
