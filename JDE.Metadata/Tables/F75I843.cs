using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I843 - .
/// </summary>
public class F75I843 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHDOCO.
        /// </summary>
        public const string IHDOCO = "IHDOCO";

        /// <summary>
        /// IHDCTO.
        /// </summary>
        public const string IHDCTO = "IHDCTO";

        /// <summary>
        /// IHKCOO.
        /// </summary>
        public const string IHKCOO = "IHKCOO";

        /// <summary>
        /// IHSFXO.
        /// </summary>
        public const string IHSFXO = "IHSFXO";

        /// <summary>
        /// IHLNID.
        /// </summary>
        public const string IHLNID = "IHLNID";

        /// <summary>
        /// IHUITM.
        /// </summary>
        public const string IHUITM = "IHUITM";

        /// <summary>
        /// IHI75ITTY.
        /// </summary>
        public const string IHI75ITTY = "IHI75ITTY";

        /// <summary>
        /// IHI75CATTY.
        /// </summary>
        public const string IHI75CATTY = "IHI75CATTY";

        /// <summary>
        /// IHI75CATVL.
        /// </summary>
        public const string IHI75CATVL = "IHI75CATVL";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHJOBN.
        /// </summary>
        public const string IHJOBN = "IHJOBN";

        /// <summary>
        /// IHUPMJ.
        /// </summary>
        public const string IHUPMJ = "IHUPMJ";

        /// <summary>
        /// IHUPMT.
        /// </summary>
        public const string IHUPMT = "IHUPMT";

        /// <summary>
        /// IHYFUTDT1.
        /// </summary>
        public const string IHYFUTDT1 = "IHYFUTDT1";

        /// <summary>
        /// IHFUT6.
        /// </summary>
        public const string IHFUT6 = "IHFUT6";

        /// <summary>
        /// IHYT04.
        /// </summary>
        public const string IHYT04 = "IHYT04";

        /// <summary>
        /// IHYFLAG.
        /// </summary>
        public const string IHYFLAG = "IHYFLAG";

        /// <summary>
        /// IHYNUM1.
        /// </summary>
        public const string IHYNUM1 = "IHYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I843";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHDOCO", "IHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IHDCTO", "IHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IHKCOO", "IHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IHSFXO", "IHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("IHLNID", "IHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHUITM", "IHUITM", JdeDataType.String, 52),
        new JdeField("IHI75ITTY", "IHI75ITTY", JdeDataType.String, 12),
        new JdeField("IHI75CATTY", "IHI75CATTY", JdeDataType.String, 6),
        new JdeField("IHI75CATVL", "IHI75CATVL", JdeDataType.String, 40),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHJOBN", "IHJOBN", JdeDataType.String, 20),
        new JdeField("IHUPMJ", "IHUPMJ", JdeDataType.Numeric),
        new JdeField("IHUPMT", "IHUPMT", JdeDataType.Numeric),
        new JdeField("IHYFUTDT1", "IHYFUTDT1", JdeDataType.Numeric),
        new JdeField("IHFUT6", "IHFUT6", JdeDataType.String, 60),
        new JdeField("IHYT04", "IHYT04", JdeDataType.String, 2),
        new JdeField("IHYFLAG", "IHYFLAG", JdeDataType.String, 2),
        new JdeField("IHYNUM1", "IHYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I843_0", "Primary Key on IHDOCO, IHDCTO, IHKCOO, IHSFXO, IHLNID", new[] { "IHDOCO", "IHDCTO", "IHKCOO", "IHSFXO", "IHLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
