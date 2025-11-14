using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T1113 - .
/// </summary>
public class F75T1113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRRTTY.
        /// </summary>
        public const string TRRTTY = "TRRTTY";

        /// <summary>
        /// TRCRDC.
        /// </summary>
        public const string TRCRDC = "TRCRDC";

        /// <summary>
        /// TRCRCD.
        /// </summary>
        public const string TRCRCD = "TRCRCD";

        /// <summary>
        /// TREFT.
        /// </summary>
        public const string TREFT = "TREFT";

        /// <summary>
        /// TRCRR.
        /// </summary>
        public const string TRCRR = "TRCRR";

        /// <summary>
        /// TRCRRD.
        /// </summary>
        public const string TRCRRD = "TRCRRD";

        /// <summary>
        /// TREFDJ.
        /// </summary>
        public const string TREFDJ = "TREFDJ";

        /// <summary>
        /// TREFTJ.
        /// </summary>
        public const string TREFTJ = "TREFTJ";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRTDAY.
        /// </summary>
        public const string TRTDAY = "TRTDAY";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75T1113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRRTTY", "TRRTTY", JdeDataType.String, 4, true, true),
        new JdeField("TRCRDC", "TRCRDC", JdeDataType.String, 6, true, true),
        new JdeField("TRCRCD", "TRCRCD", JdeDataType.String, 6, true, true),
        new JdeField("TREFT", "TREFT", JdeDataType.Numeric, null, true, true),
        new JdeField("TRCRR", "TRCRR", JdeDataType.Numeric),
        new JdeField("TRCRRD", "TRCRRD", JdeDataType.Numeric),
        new JdeField("TREFDJ", "TREFDJ", JdeDataType.Numeric),
        new JdeField("TREFTJ", "TREFTJ", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRTDAY", "TRTDAY", JdeDataType.Numeric),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T1113_0", "Primary Key on TRRTTY, TRCRDC, TRCRCD, TREFT", new[] { "TRRTTY", "TRCRDC", "TRCRCD", "TREFT" }, isUnique: true, isPrimaryKey: true)
    };
}
