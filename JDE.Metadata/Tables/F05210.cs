using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05210 - .
/// </summary>
public class F05210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWAWBTI.
        /// </summary>
        public const string AWAWBTI = "AWAWBTI";

        /// <summary>
        /// AWAWBTP.
        /// </summary>
        public const string AWAWBTP = "AWAWBTP";

        /// <summary>
        /// AWAWBTN.
        /// </summary>
        public const string AWAWBTN = "AWAWBTN";

        /// <summary>
        /// AWAWBTD.
        /// </summary>
        public const string AWAWBTD = "AWAWBTD";

        /// <summary>
        /// AWAWBTA.
        /// </summary>
        public const string AWAWBTA = "AWAWBTA";

        /// <summary>
        /// AWPID.
        /// </summary>
        public const string AWPID = "AWPID";

        /// <summary>
        /// AWUSER.
        /// </summary>
        public const string AWUSER = "AWUSER";

        /// <summary>
        /// AWUPMJ.
        /// </summary>
        public const string AWUPMJ = "AWUPMJ";

        /// <summary>
        /// AWUPMT.
        /// </summary>
        public const string AWUPMT = "AWUPMT";

        /// <summary>
        /// AWMKEY.
        /// </summary>
        public const string AWMKEY = "AWMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F05210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWAWBTI", "AWAWBTI", JdeDataType.Numeric, null, true, true),
        new JdeField("AWAWBTP", "AWAWBTP", JdeDataType.Numeric),
        new JdeField("AWAWBTN", "AWAWBTN", JdeDataType.String, 100),
        new JdeField("AWAWBTD", "AWAWBTD", JdeDataType.String, 4000),
        new JdeField("AWAWBTA", "AWAWBTA", JdeDataType.String, 20),
        new JdeField("AWPID", "AWPID", JdeDataType.String, 20),
        new JdeField("AWUSER", "AWUSER", JdeDataType.String, 20),
        new JdeField("AWUPMJ", "AWUPMJ", JdeDataType.Numeric),
        new JdeField("AWUPMT", "AWUPMT", JdeDataType.Numeric),
        new JdeField("AWMKEY", "AWMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05210_0", "Primary Key on AWAWBTI", new[] { "AWAWBTI" }, isUnique: true, isPrimaryKey: true)
    };
}
