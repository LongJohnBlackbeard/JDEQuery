using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08405 - .
/// </summary>
public class F08405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALAPLUSER.
        /// </summary>
        public const string ALAPLUSER = "ALAPLUSER";

        /// <summary>
        /// ALAPLPSWD.
        /// </summary>
        public const string ALAPLPSWD = "ALAPLPSWD";

        /// <summary>
        /// ALEMAL.
        /// </summary>
        public const string ALEMAL = "ALEMAL";

        /// <summary>
        /// ALLASTLOGIN.
        /// </summary>
        public const string ALLASTLOGIN = "ALLASTLOGIN";

        /// <summary>
        /// ALNURC.
        /// </summary>
        public const string ALNURC = "ALNURC";

        /// <summary>
        /// ALEAP.
        /// </summary>
        public const string ALEAP = "ALEAP";

        /// <summary>
        /// ALMACH.
        /// </summary>
        public const string ALMACH = "ALMACH";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALUPMT.
        /// </summary>
        public const string ALUPMT = "ALUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALAPLUSER", "ALAPLUSER", JdeDataType.String, 140, true, true),
        new JdeField("ALAPLPSWD", "ALAPLPSWD", JdeDataType.String),
        new JdeField("ALEMAL", "ALEMAL", JdeDataType.String, 512),
        new JdeField("ALLASTLOGIN", "ALLASTLOGIN", JdeDataType.Numeric),
        new JdeField("ALNURC", "ALNURC", JdeDataType.Numeric),
        new JdeField("ALEAP", "ALEAP", JdeDataType.String, 20),
        new JdeField("ALMACH", "ALMACH", JdeDataType.String, 24),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALUPMT", "ALUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08405_0", "Primary Key on ALAPLUSER", new[] { "ALAPLUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08405_2", "Index on ALNURC", new[] { "ALNURC" })
    };
}
