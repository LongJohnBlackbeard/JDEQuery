using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952330 - .
/// </summary>
public class F952330 : JdeTable
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
        /// BHBHFMNM.
        /// </summary>
        public const string BHBHFMNM = "BHBHFMNM";

        /// <summary>
        /// BHKEYCTRLST.
        /// </summary>
        public const string BHKEYCTRLST = "BHKEYCTRLST";

        /// <summary>
        /// BHKEYALIALST.
        /// </summary>
        public const string BHKEYALIALST = "BHKEYALIALST";

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

        /// <summary>
        /// BHBHFU17.
        /// </summary>
        public const string BHBHFU17 = "BHBHFU17";

        /// <summary>
        /// BHBHFU18.
        /// </summary>
        public const string BHBHFU18 = "BHBHFU18";

        /// <summary>
        /// BHBHFU19.
        /// </summary>
        public const string BHBHFU19 = "BHBHFU19";

        /// <summary>
        /// BHBHFU20.
        /// </summary>
        public const string BHBHFU20 = "BHBHFU20";

        /// <summary>
        /// BHBHFU21.
        /// </summary>
        public const string BHBHFU21 = "BHBHFU21";

        /// <summary>
        /// BHBHFU22.
        /// </summary>
        public const string BHBHFU22 = "BHBHFU22";

        /// <summary>
        /// BHBHFU23.
        /// </summary>
        public const string BHBHFU23 = "BHBHFU23";

        /// <summary>
        /// BHBHFU24.
        /// </summary>
        public const string BHBHFU24 = "BHBHFU24";
    }

    /// <inheritdoc />
    public override string TableName => "F952330";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHPRODTP", "BHPRODTP", JdeDataType.String, 20, true, true),
        new JdeField("BHBHFMNM", "BHBHFMNM", JdeDataType.String, 20, true, true),
        new JdeField("BHKEYCTRLST", "BHKEYCTRLST", JdeDataType.String, 340, true, true),
        new JdeField("BHKEYALIALST", "BHKEYALIALST", JdeDataType.String, 340),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHMKEY", "BHMKEY", JdeDataType.String, 30),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric),
        new JdeField("BHBHFU17", "BHBHFU17", JdeDataType.String, 2),
        new JdeField("BHBHFU18", "BHBHFU18", JdeDataType.String, 60),
        new JdeField("BHBHFU19", "BHBHFU19", JdeDataType.Numeric),
        new JdeField("BHBHFU20", "BHBHFU20", JdeDataType.String, 500),
        new JdeField("BHBHFU21", "BHBHFU21", JdeDataType.String, 2),
        new JdeField("BHBHFU22", "BHBHFU22", JdeDataType.String, 60),
        new JdeField("BHBHFU23", "BHBHFU23", JdeDataType.Numeric),
        new JdeField("BHBHFU24", "BHBHFU24", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952330_0", "Primary Key on BHPRODTP, BHBHFMNM, BHKEYCTRLST", new[] { "BHPRODTP", "BHBHFMNM", "BHKEYCTRLST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F952330_2", "Index on BHPRODTP, BHBHFMNM", new[] { "BHPRODTP", "BHBHFMNM" })
    };
}
