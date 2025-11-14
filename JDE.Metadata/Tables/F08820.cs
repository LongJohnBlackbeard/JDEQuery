using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08820 - .
/// </summary>
public class F08820 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTIGDLT.
        /// </summary>
        public const string YTIGDLT = "YTIGDLT";

        /// <summary>
        /// YTEFT.
        /// </summary>
        public const string YTEFT = "YTEFT";

        /// <summary>
        /// YTEFTE.
        /// </summary>
        public const string YTEFTE = "YTEFTE";

        /// <summary>
        /// YTDL01.
        /// </summary>
        public const string YTDL01 = "YTDL01";

        /// <summary>
        /// YTGLIM.
        /// </summary>
        public const string YTGLIM = "YTGLIM";

        /// <summary>
        /// YTCOLF.
        /// </summary>
        public const string YTCOLF = "YTCOLF";

        /// <summary>
        /// YTRWF.
        /// </summary>
        public const string YTRWF = "YTRWF";

        /// <summary>
        /// YTCR1FR.
        /// </summary>
        public const string YTCR1FR = "YTCR1FR";

        /// <summary>
        /// YTCR1T.
        /// </summary>
        public const string YTCR1T = "YTCR1T";

        /// <summary>
        /// YTCR2FR.
        /// </summary>
        public const string YTCR2FR = "YTCR2FR";

        /// <summary>
        /// YTCR2T.
        /// </summary>
        public const string YTCR2T = "YTCR2T";

        /// <summary>
        /// YTCR3FR.
        /// </summary>
        public const string YTCR3FR = "YTCR3FR";

        /// <summary>
        /// YTCR3T.
        /// </summary>
        public const string YTCR3T = "YTCR3T";

        /// <summary>
        /// YTCR4FR.
        /// </summary>
        public const string YTCR4FR = "YTCR4FR";

        /// <summary>
        /// YTCR4T.
        /// </summary>
        public const string YTCR4T = "YTCR4T";

        /// <summary>
        /// YTCR5FR.
        /// </summary>
        public const string YTCR5FR = "YTCR5FR";

        /// <summary>
        /// YTCR5T.
        /// </summary>
        public const string YTCR5T = "YTCR5T";

        /// <summary>
        /// YTCR6FR.
        /// </summary>
        public const string YTCR6FR = "YTCR6FR";

        /// <summary>
        /// YTCR6T.
        /// </summary>
        public const string YTCR6T = "YTCR6T";

        /// <summary>
        /// YTUSER.
        /// </summary>
        public const string YTUSER = "YTUSER";

        /// <summary>
        /// YTPID.
        /// </summary>
        public const string YTPID = "YTPID";

        /// <summary>
        /// YTUPMJ.
        /// </summary>
        public const string YTUPMJ = "YTUPMJ";

        /// <summary>
        /// YTUPMT.
        /// </summary>
        public const string YTUPMT = "YTUPMT";

        /// <summary>
        /// YTJOBN.
        /// </summary>
        public const string YTJOBN = "YTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08820";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTIGDLT", "YTIGDLT", JdeDataType.String, 20, true, true),
        new JdeField("YTEFT", "YTEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("YTEFTE", "YTEFTE", JdeDataType.Numeric),
        new JdeField("YTDL01", "YTDL01", JdeDataType.String, 60),
        new JdeField("YTGLIM", "YTGLIM", JdeDataType.String, 2),
        new JdeField("YTCOLF", "YTCOLF", JdeDataType.String, 20),
        new JdeField("YTRWF", "YTRWF", JdeDataType.String, 20),
        new JdeField("YTCR1FR", "YTCR1FR", JdeDataType.Numeric),
        new JdeField("YTCR1T", "YTCR1T", JdeDataType.Numeric),
        new JdeField("YTCR2FR", "YTCR2FR", JdeDataType.Numeric),
        new JdeField("YTCR2T", "YTCR2T", JdeDataType.Numeric),
        new JdeField("YTCR3FR", "YTCR3FR", JdeDataType.Numeric),
        new JdeField("YTCR3T", "YTCR3T", JdeDataType.Numeric),
        new JdeField("YTCR4FR", "YTCR4FR", JdeDataType.Numeric),
        new JdeField("YTCR4T", "YTCR4T", JdeDataType.Numeric),
        new JdeField("YTCR5FR", "YTCR5FR", JdeDataType.Numeric),
        new JdeField("YTCR5T", "YTCR5T", JdeDataType.Numeric),
        new JdeField("YTCR6FR", "YTCR6FR", JdeDataType.Numeric),
        new JdeField("YTCR6T", "YTCR6T", JdeDataType.Numeric),
        new JdeField("YTUSER", "YTUSER", JdeDataType.String, 20),
        new JdeField("YTPID", "YTPID", JdeDataType.String, 20),
        new JdeField("YTUPMJ", "YTUPMJ", JdeDataType.Numeric),
        new JdeField("YTUPMT", "YTUPMT", JdeDataType.Numeric),
        new JdeField("YTJOBN", "YTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08820_0", "Primary Key on YTIGDLT, YTEFT", new[] { "YTIGDLT", "YTEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
