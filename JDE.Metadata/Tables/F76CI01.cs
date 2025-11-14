using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CI01 - .
/// </summary>
public class F76CI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACOBNM.
        /// </summary>
        public const string ACOBNM = "ACOBNM";

        /// <summary>
        /// AC76CSYS.
        /// </summary>
        public const string AC76CSYS = "AC76CSYS";

        /// <summary>
        /// AC76CACT.
        /// </summary>
        public const string AC76CACT = "AC76CACT";

        /// <summary>
        /// AC76CGEN.
        /// </summary>
        public const string AC76CGEN = "AC76CGEN";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76CI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACOBNM", "ACOBNM", JdeDataType.String, 20, true, true),
        new JdeField("AC76CSYS", "AC76CSYS", JdeDataType.String, 2),
        new JdeField("AC76CACT", "AC76CACT", JdeDataType.String, 2),
        new JdeField("AC76CGEN", "AC76CGEN", JdeDataType.String, 2),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CI01_0", "Primary Key on ACOBNM", new[] { "ACOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
