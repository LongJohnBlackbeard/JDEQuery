using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41F301T - .
/// </summary>
public class F41F301T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDOCO.
        /// </summary>
        public const string APDOCO = "APDOCO";

        /// <summary>
        /// APDCTO.
        /// </summary>
        public const string APDCTO = "APDCTO";

        /// <summary>
        /// APKCOO.
        /// </summary>
        public const string APKCOO = "APKCOO";

        /// <summary>
        /// APSFXO.
        /// </summary>
        public const string APSFXO = "APSFXO";

        /// <summary>
        /// APC9COLL.
        /// </summary>
        public const string APC9COLL = "APC9COLL";

        /// <summary>
        /// APC9SEAC.
        /// </summary>
        public const string APC9SEAC = "APC9SEAC";

        /// <summary>
        /// APC9SEAY.
        /// </summary>
        public const string APC9SEAY = "APC9SEAY";

        /// <summary>
        /// APC9PRDJ.
        /// </summary>
        public const string APC9PRDJ = "APC9PRDJ";

        /// <summary>
        /// APAPPELC01.
        /// </summary>
        public const string APAPPELC01 = "APAPPELC01";

        /// <summary>
        /// APAPPELC02.
        /// </summary>
        public const string APAPPELC02 = "APAPPELC02";

        /// <summary>
        /// APAPPELC03.
        /// </summary>
        public const string APAPPELC03 = "APAPPELC03";

        /// <summary>
        /// APAPPELC04.
        /// </summary>
        public const string APAPPELC04 = "APAPPELC04";

        /// <summary>
        /// APAPPELC05.
        /// </summary>
        public const string APAPPELC05 = "APAPPELC05";

        /// <summary>
        /// APAPPELS01.
        /// </summary>
        public const string APAPPELS01 = "APAPPELS01";

        /// <summary>
        /// APAPPELS02.
        /// </summary>
        public const string APAPPELS02 = "APAPPELS02";

        /// <summary>
        /// APAPPELS03.
        /// </summary>
        public const string APAPPELS03 = "APAPPELS03";

        /// <summary>
        /// APAPPELS04.
        /// </summary>
        public const string APAPPELS04 = "APAPPELS04";

        /// <summary>
        /// APAPPELS05.
        /// </summary>
        public const string APAPPELS05 = "APAPPELS05";

        /// <summary>
        /// APAPPELD01.
        /// </summary>
        public const string APAPPELD01 = "APAPPELD01";

        /// <summary>
        /// APAPPELD02.
        /// </summary>
        public const string APAPPELD02 = "APAPPELD02";

        /// <summary>
        /// APAPPELD03.
        /// </summary>
        public const string APAPPELD03 = "APAPPELD03";

        /// <summary>
        /// APAPPELD04.
        /// </summary>
        public const string APAPPELD04 = "APAPPELD04";

        /// <summary>
        /// APAPPELD05.
        /// </summary>
        public const string APAPPELD05 = "APAPPELD05";

        /// <summary>
        /// APAPPELN01.
        /// </summary>
        public const string APAPPELN01 = "APAPPELN01";

        /// <summary>
        /// APAPPELN02.
        /// </summary>
        public const string APAPPELN02 = "APAPPELN02";

        /// <summary>
        /// APAPPELN03.
        /// </summary>
        public const string APAPPELN03 = "APAPPELN03";

        /// <summary>
        /// APAPPELN04.
        /// </summary>
        public const string APAPPELN04 = "APAPPELN04";

        /// <summary>
        /// APAPPELN05.
        /// </summary>
        public const string APAPPELN05 = "APAPPELN05";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APMKEY.
        /// </summary>
        public const string APMKEY = "APMKEY";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F41F301T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDOCO", "APDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("APDCTO", "APDCTO", JdeDataType.String, 4, true, true),
        new JdeField("APKCOO", "APKCOO", JdeDataType.String, 10, true, true),
        new JdeField("APSFXO", "APSFXO", JdeDataType.String, 6, true, true),
        new JdeField("APC9COLL", "APC9COLL", JdeDataType.String, 20),
        new JdeField("APC9SEAC", "APC9SEAC", JdeDataType.String, 4),
        new JdeField("APC9SEAY", "APC9SEAY", JdeDataType.String, 8),
        new JdeField("APC9PRDJ", "APC9PRDJ", JdeDataType.Numeric),
        new JdeField("APAPPELC01", "APAPPELC01", JdeDataType.String, 2),
        new JdeField("APAPPELC02", "APAPPELC02", JdeDataType.String, 2),
        new JdeField("APAPPELC03", "APAPPELC03", JdeDataType.String, 2),
        new JdeField("APAPPELC04", "APAPPELC04", JdeDataType.String, 2),
        new JdeField("APAPPELC05", "APAPPELC05", JdeDataType.String, 2),
        new JdeField("APAPPELS01", "APAPPELS01", JdeDataType.String, 60),
        new JdeField("APAPPELS02", "APAPPELS02", JdeDataType.String, 60),
        new JdeField("APAPPELS03", "APAPPELS03", JdeDataType.String, 60),
        new JdeField("APAPPELS04", "APAPPELS04", JdeDataType.String, 60),
        new JdeField("APAPPELS05", "APAPPELS05", JdeDataType.String, 60),
        new JdeField("APAPPELD01", "APAPPELD01", JdeDataType.Numeric),
        new JdeField("APAPPELD02", "APAPPELD02", JdeDataType.Numeric),
        new JdeField("APAPPELD03", "APAPPELD03", JdeDataType.Numeric),
        new JdeField("APAPPELD04", "APAPPELD04", JdeDataType.Numeric),
        new JdeField("APAPPELD05", "APAPPELD05", JdeDataType.Numeric),
        new JdeField("APAPPELN01", "APAPPELN01", JdeDataType.Numeric),
        new JdeField("APAPPELN02", "APAPPELN02", JdeDataType.Numeric),
        new JdeField("APAPPELN03", "APAPPELN03", JdeDataType.Numeric),
        new JdeField("APAPPELN04", "APAPPELN04", JdeDataType.Numeric),
        new JdeField("APAPPELN05", "APAPPELN05", JdeDataType.Numeric),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APMKEY", "APMKEY", JdeDataType.String, 30),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41F301T_0", "Primary Key on APDOCO, APDCTO, APKCOO, APSFXO", new[] { "APDOCO", "APDCTO", "APKCOO", "APSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
