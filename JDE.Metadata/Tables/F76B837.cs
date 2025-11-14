using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B837 - .
/// </summary>
public class F76B837 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FBAID.
        /// </summary>
        public const string FBAID = "FBAID";

        /// <summary>
        /// FBCTRY.
        /// </summary>
        public const string FBCTRY = "FBCTRY";

        /// <summary>
        /// FBFY.
        /// </summary>
        public const string FBFY = "FBFY";

        /// <summary>
        /// FBPQTR.
        /// </summary>
        public const string FBPQTR = "FBPQTR";

        /// <summary>
        /// FBANI.
        /// </summary>
        public const string FBANI = "FBANI";

        /// <summary>
        /// FBB76FFCB.
        /// </summary>
        public const string FBB76FFCB = "FBB76FFCB";

        /// <summary>
        /// FBB76FFFB.
        /// </summary>
        public const string FBB76FFFB = "FBB76FFFB";

        /// <summary>
        /// FBB76FCED.
        /// </summary>
        public const string FBB76FCED = "FBB76FCED";

        /// <summary>
        /// FBB76FCEC.
        /// </summary>
        public const string FBB76FCEC = "FBB76FCEC";

        /// <summary>
        /// FBB76FCID.
        /// </summary>
        public const string FBB76FCID = "FBB76FCID";

        /// <summary>
        /// FBB76FCIC.
        /// </summary>
        public const string FBB76FCIC = "FBB76FCIC";

        /// <summary>
        /// FBUSER.
        /// </summary>
        public const string FBUSER = "FBUSER";

        /// <summary>
        /// FBPID.
        /// </summary>
        public const string FBPID = "FBPID";

        /// <summary>
        /// FBJOBN.
        /// </summary>
        public const string FBJOBN = "FBJOBN";

        /// <summary>
        /// FBUPMJ.
        /// </summary>
        public const string FBUPMJ = "FBUPMJ";

        /// <summary>
        /// FBUPMT.
        /// </summary>
        public const string FBUPMT = "FBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B837";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FBAID", "FBAID", JdeDataType.String, 16, true, true),
        new JdeField("FBCTRY", "FBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("FBFY", "FBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("FBPQTR", "FBPQTR", JdeDataType.String, 2, true, true),
        new JdeField("FBANI", "FBANI", JdeDataType.String, 58),
        new JdeField("FBB76FFCB", "FBB76FFCB", JdeDataType.Numeric),
        new JdeField("FBB76FFFB", "FBB76FFFB", JdeDataType.Numeric),
        new JdeField("FBB76FCED", "FBB76FCED", JdeDataType.Numeric),
        new JdeField("FBB76FCEC", "FBB76FCEC", JdeDataType.Numeric),
        new JdeField("FBB76FCID", "FBB76FCID", JdeDataType.Numeric),
        new JdeField("FBB76FCIC", "FBB76FCIC", JdeDataType.Numeric),
        new JdeField("FBUSER", "FBUSER", JdeDataType.String, 20),
        new JdeField("FBPID", "FBPID", JdeDataType.String, 20),
        new JdeField("FBJOBN", "FBJOBN", JdeDataType.String, 20),
        new JdeField("FBUPMJ", "FBUPMJ", JdeDataType.Numeric),
        new JdeField("FBUPMT", "FBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B837_0", "Primary Key on FBAID, FBFY, FBCTRY, FBPQTR", new[] { "FBAID", "FBFY", "FBCTRY", "FBPQTR" }, isUnique: true, isPrimaryKey: true)
    };
}
