using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952331 - .
/// </summary>
public class F952331 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHPRODTP.
        /// </summary>
        public const string BHPRODTP = "BHPRODTP";

        /// <summary>
        /// BHBHUSER.
        /// </summary>
        public const string BHBHUSER = "BHBHUSER";

        /// <summary>
        /// BHBHFMNM.
        /// </summary>
        public const string BHBHFMNM = "BHBHFMNM";

        /// <summary>
        /// BHKEYCTRLST.
        /// </summary>
        public const string BHKEYCTRLST = "BHKEYCTRLST";

        /// <summary>
        /// BHKEYVALLST.
        /// </summary>
        public const string BHKEYVALLST = "BHKEYVALLST";

        /// <summary>
        /// BHXREFOBID.
        /// </summary>
        public const string BHXREFOBID = "BHXREFOBID";

        /// <summary>
        /// BHBHFU1.
        /// </summary>
        public const string BHBHFU1 = "BHBHFU1";

        /// <summary>
        /// BHBHFU2.
        /// </summary>
        public const string BHBHFU2 = "BHBHFU2";

        /// <summary>
        /// BHBHFU3.
        /// </summary>
        public const string BHBHFU3 = "BHBHFU3";

        /// <summary>
        /// BHBHFU4.
        /// </summary>
        public const string BHBHFU4 = "BHBHFU4";

        /// <summary>
        /// BHBHFU5.
        /// </summary>
        public const string BHBHFU5 = "BHBHFU5";

        /// <summary>
        /// BHBHFU6.
        /// </summary>
        public const string BHBHFU6 = "BHBHFU6";

        /// <summary>
        /// BHBHFU7.
        /// </summary>
        public const string BHBHFU7 = "BHBHFU7";

        /// <summary>
        /// BHBHFU8.
        /// </summary>
        public const string BHBHFU8 = "BHBHFU8";

        /// <summary>
        /// BHUSER.
        /// </summary>
        public const string BHUSER = "BHUSER";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";

        /// <summary>
        /// BHMKEY.
        /// </summary>
        public const string BHMKEY = "BHMKEY";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHUPMT.
        /// </summary>
        public const string BHUPMT = "BHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F952331";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHPRODTP", "BHPRODTP", JdeDataType.String, 20, true, true),
        new JdeField("BHBHUSER", "BHBHUSER", JdeDataType.String, 20),
        new JdeField("BHBHFMNM", "BHBHFMNM", JdeDataType.String, 20, true, true),
        new JdeField("BHKEYCTRLST", "BHKEYCTRLST", JdeDataType.String, 340, true, true),
        new JdeField("BHKEYVALLST", "BHKEYVALLST", JdeDataType.String, 340, true, true),
        new JdeField("BHXREFOBID", "BHXREFOBID", JdeDataType.String, 140, true, true),
        new JdeField("BHBHFU1", "BHBHFU1", JdeDataType.String, 2),
        new JdeField("BHBHFU2", "BHBHFU2", JdeDataType.String, 60),
        new JdeField("BHBHFU3", "BHBHFU3", JdeDataType.Numeric),
        new JdeField("BHBHFU4", "BHBHFU4", JdeDataType.String, 500),
        new JdeField("BHBHFU5", "BHBHFU5", JdeDataType.String, 2),
        new JdeField("BHBHFU6", "BHBHFU6", JdeDataType.String, 60),
        new JdeField("BHBHFU7", "BHBHFU7", JdeDataType.Numeric),
        new JdeField("BHBHFU8", "BHBHFU8", JdeDataType.Numeric),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHMKEY", "BHMKEY", JdeDataType.String, 30),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952331_0", "Primary Key on BHPRODTP, BHBHFMNM, BHKEYCTRLST, BHKEYVALLST, BHXREFOBID", new[] { "BHPRODTP", "BHBHFMNM", "BHKEYCTRLST", "BHKEYVALLST", "BHXREFOBID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F952331_2", "Index on BHPRODTP, BHBHFMNM, BHKEYCTRLST, BHKEYVALLST", new[] { "BHPRODTP", "BHBHFMNM", "BHKEYCTRLST", "BHKEYVALLST" })
    };
}
