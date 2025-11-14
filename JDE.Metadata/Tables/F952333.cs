using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952333 - .
/// </summary>
public class F952333 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHBHUSER.
        /// </summary>
        public const string BHBHUSER = "BHBHUSER";

        /// <summary>
        /// BHPRODTP.
        /// </summary>
        public const string BHPRODTP = "BHPRODTP";

        /// <summary>
        /// BHXREFUSID.
        /// </summary>
        public const string BHXREFUSID = "BHXREFUSID";

        /// <summary>
        /// BHXREFPSWEN.
        /// </summary>
        public const string BHXREFPSWEN = "BHXREFPSWEN";

        /// <summary>
        /// BHBHFU9.
        /// </summary>
        public const string BHBHFU9 = "BHBHFU9";

        /// <summary>
        /// BHBHFU10.
        /// </summary>
        public const string BHBHFU10 = "BHBHFU10";

        /// <summary>
        /// BHBHFU11.
        /// </summary>
        public const string BHBHFU11 = "BHBHFU11";

        /// <summary>
        /// BHBHFU12.
        /// </summary>
        public const string BHBHFU12 = "BHBHFU12";

        /// <summary>
        /// BHBHFU13.
        /// </summary>
        public const string BHBHFU13 = "BHBHFU13";

        /// <summary>
        /// BHBHFU14.
        /// </summary>
        public const string BHBHFU14 = "BHBHFU14";

        /// <summary>
        /// BHBHFU15.
        /// </summary>
        public const string BHBHFU15 = "BHBHFU15";

        /// <summary>
        /// BHBHFU16.
        /// </summary>
        public const string BHBHFU16 = "BHBHFU16";

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
    public override string TableName => "F952333";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHBHUSER", "BHBHUSER", JdeDataType.String, 20, true, true),
        new JdeField("BHPRODTP", "BHPRODTP", JdeDataType.String, 20, true, true),
        new JdeField("BHXREFUSID", "BHXREFUSID", JdeDataType.String, 100),
        new JdeField("BHXREFPSWEN", "BHXREFPSWEN", JdeDataType.String, 1024),
        new JdeField("BHBHFU9", "BHBHFU9", JdeDataType.String, 2),
        new JdeField("BHBHFU10", "BHBHFU10", JdeDataType.String, 60),
        new JdeField("BHBHFU11", "BHBHFU11", JdeDataType.Numeric),
        new JdeField("BHBHFU12", "BHBHFU12", JdeDataType.String, 500),
        new JdeField("BHBHFU13", "BHBHFU13", JdeDataType.String, 2),
        new JdeField("BHBHFU14", "BHBHFU14", JdeDataType.String, 60),
        new JdeField("BHBHFU15", "BHBHFU15", JdeDataType.Numeric),
        new JdeField("BHBHFU16", "BHBHFU16", JdeDataType.Numeric),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHMKEY", "BHMKEY", JdeDataType.String, 30),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952333_0", "Primary Key on BHBHUSER, BHPRODTP", new[] { "BHBHUSER", "BHPRODTP" }, isUnique: true, isPrimaryKey: true)
    };
}
