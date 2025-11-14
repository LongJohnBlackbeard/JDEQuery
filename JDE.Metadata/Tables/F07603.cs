using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07603 - .
/// </summary>
public class F07603 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FVLVVS.
        /// </summary>
        public const string FVLVVS = "FVLVVS";

        /// <summary>
        /// FVLRSEGN.
        /// </summary>
        public const string FVLRSEGN = "FVLRSEGN";

        /// <summary>
        /// FVLRSEGID.
        /// </summary>
        public const string FVLRSEGID = "FVLRSEGID";

        /// <summary>
        /// FVLTTP.
        /// </summary>
        public const string FVLTTP = "FVLTTP";

        /// <summary>
        /// FVSSUBF.
        /// </summary>
        public const string FVSSUBF = "FVSSUBF";

        /// <summary>
        /// FVSSUBR.
        /// </summary>
        public const string FVSSUBR = "FVSSUBR";

        /// <summary>
        /// FVVSUBF.
        /// </summary>
        public const string FVVSUBF = "FVVSUBF";

        /// <summary>
        /// FVOSUBF.
        /// </summary>
        public const string FVOSUBF = "FVOSUBF";

        /// <summary>
        /// FVSSUBO.
        /// </summary>
        public const string FVSSUBO = "FVSSUBO";

        /// <summary>
        /// FVVSUBO.
        /// </summary>
        public const string FVVSUBO = "FVVSUBO";

        /// <summary>
        /// FVOSUBO.
        /// </summary>
        public const string FVOSUBO = "FVOSUBO";

        /// <summary>
        /// FVLVF1.
        /// </summary>
        public const string FVLVF1 = "FVLVF1";

        /// <summary>
        /// FVLVF2.
        /// </summary>
        public const string FVLVF2 = "FVLVF2";

        /// <summary>
        /// FVLVF3.
        /// </summary>
        public const string FVLVF3 = "FVLVF3";

        /// <summary>
        /// FVLVF4.
        /// </summary>
        public const string FVLVF4 = "FVLVF4";

        /// <summary>
        /// FVLVF5.
        /// </summary>
        public const string FVLVF5 = "FVLVF5";

        /// <summary>
        /// FVLVF6.
        /// </summary>
        public const string FVLVF6 = "FVLVF6";

        /// <summary>
        /// FVLVF7.
        /// </summary>
        public const string FVLVF7 = "FVLVF7";

        /// <summary>
        /// FVLVF8.
        /// </summary>
        public const string FVLVF8 = "FVLVF8";

        /// <summary>
        /// FVLVF9.
        /// </summary>
        public const string FVLVF9 = "FVLVF9";

        /// <summary>
        /// FVLVF10.
        /// </summary>
        public const string FVLVF10 = "FVLVF10";

        /// <summary>
        /// FVLVF11.
        /// </summary>
        public const string FVLVF11 = "FVLVF11";

        /// <summary>
        /// FVLVF12.
        /// </summary>
        public const string FVLVF12 = "FVLVF12";

        /// <summary>
        /// FVUSER.
        /// </summary>
        public const string FVUSER = "FVUSER";

        /// <summary>
        /// FVJOBN.
        /// </summary>
        public const string FVJOBN = "FVJOBN";

        /// <summary>
        /// FVPID.
        /// </summary>
        public const string FVPID = "FVPID";

        /// <summary>
        /// FVUPMJ.
        /// </summary>
        public const string FVUPMJ = "FVUPMJ";

        /// <summary>
        /// FVUPMT.
        /// </summary>
        public const string FVUPMT = "FVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07603";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FVLVVS", "FVLVVS", JdeDataType.String, 20, true, true),
        new JdeField("FVLRSEGN", "FVLRSEGN", JdeDataType.String, 60, true, true),
        new JdeField("FVLRSEGID", "FVLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("FVLTTP", "FVLTTP", JdeDataType.String, 4, true, true),
        new JdeField("FVSSUBF", "FVSSUBF", JdeDataType.String, 2),
        new JdeField("FVSSUBR", "FVSSUBR", JdeDataType.String, 2),
        new JdeField("FVVSUBF", "FVVSUBF", JdeDataType.String, 2),
        new JdeField("FVOSUBF", "FVOSUBF", JdeDataType.String, 2),
        new JdeField("FVSSUBO", "FVSSUBO", JdeDataType.Numeric),
        new JdeField("FVVSUBO", "FVVSUBO", JdeDataType.Numeric),
        new JdeField("FVOSUBO", "FVOSUBO", JdeDataType.Numeric),
        new JdeField("FVLVF1", "FVLVF1", JdeDataType.String, 2),
        new JdeField("FVLVF2", "FVLVF2", JdeDataType.String, 2),
        new JdeField("FVLVF3", "FVLVF3", JdeDataType.String, 2),
        new JdeField("FVLVF4", "FVLVF4", JdeDataType.String, 100),
        new JdeField("FVLVF5", "FVLVF5", JdeDataType.String, 100),
        new JdeField("FVLVF6", "FVLVF6", JdeDataType.String, 100),
        new JdeField("FVLVF7", "FVLVF7", JdeDataType.Numeric),
        new JdeField("FVLVF8", "FVLVF8", JdeDataType.Numeric),
        new JdeField("FVLVF9", "FVLVF9", JdeDataType.Numeric),
        new JdeField("FVLVF10", "FVLVF10", JdeDataType.Numeric),
        new JdeField("FVLVF11", "FVLVF11", JdeDataType.Numeric),
        new JdeField("FVLVF12", "FVLVF12", JdeDataType.Numeric),
        new JdeField("FVUSER", "FVUSER", JdeDataType.String, 20),
        new JdeField("FVJOBN", "FVJOBN", JdeDataType.String, 20),
        new JdeField("FVPID", "FVPID", JdeDataType.String, 20),
        new JdeField("FVUPMJ", "FVUPMJ", JdeDataType.Numeric),
        new JdeField("FVUPMT", "FVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07603_0", "Primary Key on FVLVVS, FVLRSEGN, FVLRSEGID, FVLTTP", new[] { "FVLVVS", "FVLRSEGN", "FVLRSEGID", "FVLTTP" }, isUnique: true, isPrimaryKey: true)
    };
}
