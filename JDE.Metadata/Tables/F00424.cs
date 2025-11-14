using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00424 - .
/// </summary>
public class F00424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACBASIST.
        /// </summary>
        public const string ACBASIST = "ACBASIST";

        /// <summary>
        /// ACRBCOL.
        /// </summary>
        public const string ACRBCOL = "ACRBCOL";

        /// <summary>
        /// ACDL01.
        /// </summary>
        public const string ACDL01 = "ACDL01";

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
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACCOLTYPE.
        /// </summary>
        public const string ACCOLTYPE = "ACCOLTYPE";
    }

    /// <inheritdoc />
    public override string TableName => "F00424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACBASIST", "ACBASIST", JdeDataType.String, 30, true, true),
        new JdeField("ACRBCOL", "ACRBCOL", JdeDataType.String, 30, true, true),
        new JdeField("ACDL01", "ACDL01", JdeDataType.String, 60),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACCOLTYPE", "ACCOLTYPE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00424_0", "Primary Key on ACBASIST, ACRBCOL", new[] { "ACBASIST", "ACRBCOL" }, isUnique: true, isPrimaryKey: true)
    };
}
