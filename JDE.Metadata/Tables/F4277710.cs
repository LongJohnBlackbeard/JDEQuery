using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277710 - .
/// </summary>
public class F4277710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPFULPID.
        /// </summary>
        public const string FPFULPID = "FPFULPID";

        /// <summary>
        /// FPPIDDESC.
        /// </summary>
        public const string FPPIDDESC = "FPPIDDESC";

        /// <summary>
        /// FPFPDTE.
        /// </summary>
        public const string FPFPDTE = "FPFPDTE";

        /// <summary>
        /// FPVER1.
        /// </summary>
        public const string FPVER1 = "FPVER1";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPJOBN.
        /// </summary>
        public const string FPJOBN = "FPJOBN";

        /// <summary>
        /// FPUPMJ.
        /// </summary>
        public const string FPUPMJ = "FPUPMJ";

        /// <summary>
        /// FPTDAY.
        /// </summary>
        public const string FPTDAY = "FPTDAY";

        /// <summary>
        /// FPURCD.
        /// </summary>
        public const string FPURCD = "FPURCD";

        /// <summary>
        /// FPURDT.
        /// </summary>
        public const string FPURDT = "FPURDT";

        /// <summary>
        /// FPURRF.
        /// </summary>
        public const string FPURRF = "FPURRF";

        /// <summary>
        /// FPURAT.
        /// </summary>
        public const string FPURAT = "FPURAT";

        /// <summary>
        /// FPURAB.
        /// </summary>
        public const string FPURAB = "FPURAB";

        /// <summary>
        /// FPUTIME.
        /// </summary>
        public const string FPUTIME = "FPUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPFULPID", "FPFULPID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPPIDDESC", "FPPIDDESC", JdeDataType.String, 60),
        new JdeField("FPFPDTE", "FPFPDTE", JdeDataType.Date),
        new JdeField("FPVER1", "FPVER1", JdeDataType.String, 20),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPJOBN", "FPJOBN", JdeDataType.String, 20),
        new JdeField("FPUPMJ", "FPUPMJ", JdeDataType.Numeric),
        new JdeField("FPTDAY", "FPTDAY", JdeDataType.Numeric),
        new JdeField("FPURCD", "FPURCD", JdeDataType.String, 4),
        new JdeField("FPURDT", "FPURDT", JdeDataType.Numeric),
        new JdeField("FPURRF", "FPURRF", JdeDataType.String, 30),
        new JdeField("FPURAT", "FPURAT", JdeDataType.Numeric),
        new JdeField("FPURAB", "FPURAB", JdeDataType.Numeric),
        new JdeField("FPUTIME", "FPUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277710_0", "Primary Key on FPFULPID", new[] { "FPFULPID" }, isUnique: true, isPrimaryKey: true)
    };
}
