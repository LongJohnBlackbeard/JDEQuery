using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1523D - .
/// </summary>
public class F1523D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OGLGNM.
        /// </summary>
        public const string OGLGNM = "OGLGNM";

        /// <summary>
        /// OGLNGP.
        /// </summary>
        public const string OGLNGP = "OGLNGP";

        /// <summary>
        /// OGDL01.
        /// </summary>
        public const string OGDL01 = "OGDL01";

        /// <summary>
        /// OGEXR.
        /// </summary>
        public const string OGEXR = "OGEXR";

        /// <summary>
        /// OGUSER.
        /// </summary>
        public const string OGUSER = "OGUSER";

        /// <summary>
        /// OGPID.
        /// </summary>
        public const string OGPID = "OGPID";

        /// <summary>
        /// OGUPMJ.
        /// </summary>
        public const string OGUPMJ = "OGUPMJ";

        /// <summary>
        /// OGUPMT.
        /// </summary>
        public const string OGUPMT = "OGUPMT";

        /// <summary>
        /// OGJOBN.
        /// </summary>
        public const string OGJOBN = "OGJOBN";

        /// <summary>
        /// OGTORG.
        /// </summary>
        public const string OGTORG = "OGTORG";

        /// <summary>
        /// OGENTJ.
        /// </summary>
        public const string OGENTJ = "OGENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1523D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OGLGNM", "OGLGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("OGLNGP", "OGLNGP", JdeDataType.String, 4, true, true),
        new JdeField("OGDL01", "OGDL01", JdeDataType.String, 60),
        new JdeField("OGEXR", "OGEXR", JdeDataType.String, 60),
        new JdeField("OGUSER", "OGUSER", JdeDataType.String, 20),
        new JdeField("OGPID", "OGPID", JdeDataType.String, 20),
        new JdeField("OGUPMJ", "OGUPMJ", JdeDataType.Numeric),
        new JdeField("OGUPMT", "OGUPMT", JdeDataType.Numeric),
        new JdeField("OGJOBN", "OGJOBN", JdeDataType.String, 20),
        new JdeField("OGTORG", "OGTORG", JdeDataType.String, 20),
        new JdeField("OGENTJ", "OGENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1523D_0", "Primary Key on OGLGNM, OGLNGP", new[] { "OGLGNM", "OGLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
