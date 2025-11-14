using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I858 - .
/// </summary>
public class F75I858 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDI75SDNO.
        /// </summary>
        public const string SDI75SDNO = "SDI75SDNO";

        /// <summary>
        /// SDI75SDDT.
        /// </summary>
        public const string SDI75SDDT = "SDI75SDDT";

        /// <summary>
        /// SDRMK.
        /// </summary>
        public const string SDRMK = "SDRMK";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDYFUTDT1.
        /// </summary>
        public const string SDYFUTDT1 = "SDYFUTDT1";

        /// <summary>
        /// SDFUT6.
        /// </summary>
        public const string SDFUT6 = "SDFUT6";

        /// <summary>
        /// SDYT04.
        /// </summary>
        public const string SDYT04 = "SDYT04";

        /// <summary>
        /// SDYFLAG.
        /// </summary>
        public const string SDYFLAG = "SDYFLAG";

        /// <summary>
        /// SDYNUM1.
        /// </summary>
        public const string SDYNUM1 = "SDYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I858";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SDI75SDNO", "SDI75SDNO", JdeDataType.String, 50),
        new JdeField("SDI75SDDT", "SDI75SDDT", JdeDataType.Numeric),
        new JdeField("SDRMK", "SDRMK", JdeDataType.String, 60),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDYFUTDT1", "SDYFUTDT1", JdeDataType.Numeric),
        new JdeField("SDFUT6", "SDFUT6", JdeDataType.String, 60),
        new JdeField("SDYT04", "SDYT04", JdeDataType.String, 2),
        new JdeField("SDYFLAG", "SDYFLAG", JdeDataType.String, 2),
        new JdeField("SDYNUM1", "SDYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I858_0", "Primary Key on SDKCOO, SDDOCO, SDDCTO, SDSFXO", new[] { "SDKCOO", "SDDOCO", "SDDCTO", "SDSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
