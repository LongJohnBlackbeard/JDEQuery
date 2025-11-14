using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F007111 - .
/// </summary>
public class F007111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TBGPBT.
        /// </summary>
        public const string TBGPBT = "TBGPBT";

        /// <summary>
        /// TBGPTN.
        /// </summary>
        public const string TBGPTN = "TBGPTN";

        /// <summary>
        /// TBLIN.
        /// </summary>
        public const string TBLIN = "TBLIN";

        /// <summary>
        /// TBGPTX.
        /// </summary>
        public const string TBGPTX = "TBGPTX";

        /// <summary>
        /// TBGPSP.
        /// </summary>
        public const string TBGPSP = "TBGPSP";

        /// <summary>
        /// TBURC1.
        /// </summary>
        public const string TBURC1 = "TBURC1";

        /// <summary>
        /// TBURRF.
        /// </summary>
        public const string TBURRF = "TBURRF";

        /// <summary>
        /// TBURDT.
        /// </summary>
        public const string TBURDT = "TBURDT";

        /// <summary>
        /// TBURAB.
        /// </summary>
        public const string TBURAB = "TBURAB";

        /// <summary>
        /// TBUSER.
        /// </summary>
        public const string TBUSER = "TBUSER";

        /// <summary>
        /// TBPID.
        /// </summary>
        public const string TBPID = "TBPID";

        /// <summary>
        /// TBJOBN.
        /// </summary>
        public const string TBJOBN = "TBJOBN";

        /// <summary>
        /// TBUPMJ.
        /// </summary>
        public const string TBUPMJ = "TBUPMJ";

        /// <summary>
        /// TBUPMT.
        /// </summary>
        public const string TBUPMT = "TBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F007111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TBGPBT", "TBGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("TBGPTN", "TBGPTN", JdeDataType.String, 28, true, true),
        new JdeField("TBLIN", "TBLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("TBGPTX", "TBGPTX", JdeDataType.String, 3000),
        new JdeField("TBGPSP", "TBGPSP", JdeDataType.String, 2),
        new JdeField("TBURC1", "TBURC1", JdeDataType.String, 6),
        new JdeField("TBURRF", "TBURRF", JdeDataType.String, 30),
        new JdeField("TBURDT", "TBURDT", JdeDataType.Numeric),
        new JdeField("TBURAB", "TBURAB", JdeDataType.Numeric),
        new JdeField("TBUSER", "TBUSER", JdeDataType.String, 20),
        new JdeField("TBPID", "TBPID", JdeDataType.String, 20),
        new JdeField("TBJOBN", "TBJOBN", JdeDataType.String, 20),
        new JdeField("TBUPMJ", "TBUPMJ", JdeDataType.Numeric),
        new JdeField("TBUPMT", "TBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F007111_0", "Primary Key on TBGPBT, TBGPTN, TBLIN", new[] { "TBGPBT", "TBGPTN", "TBLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F007111_2", "Index on TBGPBT, TBGPTN", new[] { "TBGPBT", "TBGPTN" })
    };
}
