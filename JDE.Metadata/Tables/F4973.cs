using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4973 - .
/// </summary>
public class F4973 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TLRTNM.
        /// </summary>
        public const string TLRTNM = "TLRTNM";

        /// <summary>
        /// TLOSEQ.
        /// </summary>
        public const string TLOSEQ = "TLOSEQ";

        /// <summary>
        /// TLLUTK.
        /// </summary>
        public const string TLLUTK = "TLLUTK";

        /// <summary>
        /// TLLKVF.
        /// </summary>
        public const string TLLKVF = "TLLKVF";

        /// <summary>
        /// TLLKVT.
        /// </summary>
        public const string TLLKVT = "TLLKVT";

        /// <summary>
        /// TLLKVN.
        /// </summary>
        public const string TLLKVN = "TLLKVN";

        /// <summary>
        /// TLLKTN.
        /// </summary>
        public const string TLLKTN = "TLLKTN";

        /// <summary>
        /// TLLKLB.
        /// </summary>
        public const string TLLKLB = "TLLKLB";

        /// <summary>
        /// TLCRCD.
        /// </summary>
        public const string TLCRCD = "TLCRCD";

        /// <summary>
        /// TLUSER.
        /// </summary>
        public const string TLUSER = "TLUSER";

        /// <summary>
        /// TLPID.
        /// </summary>
        public const string TLPID = "TLPID";

        /// <summary>
        /// TLJOBN.
        /// </summary>
        public const string TLJOBN = "TLJOBN";

        /// <summary>
        /// TLUPMJ.
        /// </summary>
        public const string TLUPMJ = "TLUPMJ";

        /// <summary>
        /// TLTDAY.
        /// </summary>
        public const string TLTDAY = "TLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4973";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TLRTNM", "TLRTNM", JdeDataType.String, 20, true, true),
        new JdeField("TLOSEQ", "TLOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TLLUTK", "TLLUTK", JdeDataType.String, 2, true, true),
        new JdeField("TLLKVF", "TLLKVF", JdeDataType.String, 40),
        new JdeField("TLLKVT", "TLLKVT", JdeDataType.String, 40),
        new JdeField("TLLKVN", "TLLKVN", JdeDataType.Numeric),
        new JdeField("TLLKTN", "TLLKTN", JdeDataType.Numeric),
        new JdeField("TLLKLB", "TLLKLB", JdeDataType.String, 30),
        new JdeField("TLCRCD", "TLCRCD", JdeDataType.String, 6),
        new JdeField("TLUSER", "TLUSER", JdeDataType.String, 20),
        new JdeField("TLPID", "TLPID", JdeDataType.String, 20),
        new JdeField("TLJOBN", "TLJOBN", JdeDataType.String, 20),
        new JdeField("TLUPMJ", "TLUPMJ", JdeDataType.Numeric),
        new JdeField("TLTDAY", "TLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4973_0", "Primary Key on TLRTNM, TLOSEQ, TLLUTK", new[] { "TLRTNM", "TLOSEQ", "TLLUTK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4973_2", "Index on TLRTNM, TLLUTK, TLLKVT, TLLKVF", new[] { "TLRTNM", "TLLUTK", "TLLKVT", "TLLKVF" }),
        new JdeIndex("F4973_3", "Index on TLRTNM, TLLUTK, TLLKTN, TLLKVN", new[] { "TLRTNM", "TLLUTK", "TLLKTN", "TLLKVN" }),
        new JdeIndex("F4973_4", "Index on TLRTNM, TLLUTK, TLCRCD, TLLKTN, TLLKVN", new[] { "TLRTNM", "TLLUTK", "TLCRCD", "TLLKTN", "TLLKVN" })
    };
}
