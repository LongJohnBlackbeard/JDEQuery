using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08393 - .
/// </summary>
public class F08393 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BNPTAB.
        /// </summary>
        public const string BNPTAB = "BNPTAB";

        /// <summary>
        /// BNPPYF.
        /// </summary>
        public const string BNPPYF = "BNPPYF";

        /// <summary>
        /// BNPPYT.
        /// </summary>
        public const string BNPPYT = "BNPPYT";

        /// <summary>
        /// BNUSER.
        /// </summary>
        public const string BNUSER = "BNUSER";

        /// <summary>
        /// BNPID.
        /// </summary>
        public const string BNPID = "BNPID";

        /// <summary>
        /// BNUPMJ.
        /// </summary>
        public const string BNUPMJ = "BNUPMJ";

        /// <summary>
        /// BNJOBN.
        /// </summary>
        public const string BNJOBN = "BNJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08393";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BNPTAB", "BNPTAB", JdeDataType.String, 8, true, true),
        new JdeField("BNPPYF", "BNPPYF", JdeDataType.Numeric),
        new JdeField("BNPPYT", "BNPPYT", JdeDataType.Numeric, null, true, true),
        new JdeField("BNUSER", "BNUSER", JdeDataType.String, 20),
        new JdeField("BNPID", "BNPID", JdeDataType.String, 20),
        new JdeField("BNUPMJ", "BNUPMJ", JdeDataType.Numeric),
        new JdeField("BNJOBN", "BNJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08393_0", "Primary Key on BNPTAB, BNPPYT", new[] { "BNPTAB", "BNPPYT" }, isUnique: true, isPrimaryKey: true)
    };
}
