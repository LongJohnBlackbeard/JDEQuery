using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1531D - .
/// </summary>
public class F1531D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMEPCL.
        /// </summary>
        public const string OMEPCL = "OMEPCL";

        /// <summary>
        /// OMLNID.
        /// </summary>
        public const string OMLNID = "OMLNID";

        /// <summary>
        /// OMLNGP.
        /// </summary>
        public const string OMLNGP = "OMLNGP";

        /// <summary>
        /// OMDL01.
        /// </summary>
        public const string OMDL01 = "OMDL01";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMUPMJ.
        /// </summary>
        public const string OMUPMJ = "OMUPMJ";

        /// <summary>
        /// OMUPMT.
        /// </summary>
        public const string OMUPMT = "OMUPMT";

        /// <summary>
        /// OMJOBN.
        /// </summary>
        public const string OMJOBN = "OMJOBN";

        /// <summary>
        /// OMTORG.
        /// </summary>
        public const string OMTORG = "OMTORG";

        /// <summary>
        /// OMENTJ.
        /// </summary>
        public const string OMENTJ = "OMENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1531D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMEPCL", "OMEPCL", JdeDataType.String, 8, true, true),
        new JdeField("OMLNID", "OMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMLNGP", "OMLNGP", JdeDataType.String, 4, true, true),
        new JdeField("OMDL01", "OMDL01", JdeDataType.String, 60),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMUPMJ", "OMUPMJ", JdeDataType.Numeric),
        new JdeField("OMUPMT", "OMUPMT", JdeDataType.Numeric),
        new JdeField("OMJOBN", "OMJOBN", JdeDataType.String, 20),
        new JdeField("OMTORG", "OMTORG", JdeDataType.String, 20),
        new JdeField("OMENTJ", "OMENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1531D_0", "Primary Key on OMEPCL, OMLNID, OMLNGP", new[] { "OMEPCL", "OMLNID", "OMLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
