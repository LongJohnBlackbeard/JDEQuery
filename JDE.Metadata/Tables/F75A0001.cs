using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0001 - .
/// </summary>
public class F75A0001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZAEDTF.
        /// </summary>
        public const string ZAEDTF = "ZAEDTF";

        /// <summary>
        /// ZAEDTT.
        /// </summary>
        public const string ZAEDTT = "ZAEDTT";

        /// <summary>
        /// ZACCPR.
        /// </summary>
        public const string ZACCPR = "ZACCPR";

        /// <summary>
        /// ZASCALE.
        /// </summary>
        public const string ZASCALE = "ZASCALE";

        /// <summary>
        /// ZALIMIT01.
        /// </summary>
        public const string ZALIMIT01 = "ZALIMIT01";

        /// <summary>
        /// ZALIMIT02.
        /// </summary>
        public const string ZALIMIT02 = "ZALIMIT02";

        /// <summary>
        /// ZALIMIT03.
        /// </summary>
        public const string ZALIMIT03 = "ZALIMIT03";

        /// <summary>
        /// ZALIMIT04.
        /// </summary>
        public const string ZALIMIT04 = "ZALIMIT04";

        /// <summary>
        /// ZALIMIT05.
        /// </summary>
        public const string ZALIMIT05 = "ZALIMIT05";

        /// <summary>
        /// ZALIMIT06.
        /// </summary>
        public const string ZALIMIT06 = "ZALIMIT06";

        /// <summary>
        /// ZALIMIT07.
        /// </summary>
        public const string ZALIMIT07 = "ZALIMIT07";

        /// <summary>
        /// ZALIMIT08.
        /// </summary>
        public const string ZALIMIT08 = "ZALIMIT08";

        /// <summary>
        /// ZATRATE01.
        /// </summary>
        public const string ZATRATE01 = "ZATRATE01";

        /// <summary>
        /// ZATRATE02.
        /// </summary>
        public const string ZATRATE02 = "ZATRATE02";

        /// <summary>
        /// ZATRATE03.
        /// </summary>
        public const string ZATRATE03 = "ZATRATE03";

        /// <summary>
        /// ZATRATE04.
        /// </summary>
        public const string ZATRATE04 = "ZATRATE04";

        /// <summary>
        /// ZATRATE05.
        /// </summary>
        public const string ZATRATE05 = "ZATRATE05";

        /// <summary>
        /// ZATRATE06.
        /// </summary>
        public const string ZATRATE06 = "ZATRATE06";

        /// <summary>
        /// ZATRATE07.
        /// </summary>
        public const string ZATRATE07 = "ZATRATE07";

        /// <summary>
        /// ZATRATE08.
        /// </summary>
        public const string ZATRATE08 = "ZATRATE08";

        /// <summary>
        /// ZAADJUST01.
        /// </summary>
        public const string ZAADJUST01 = "ZAADJUST01";

        /// <summary>
        /// ZAADJUST02.
        /// </summary>
        public const string ZAADJUST02 = "ZAADJUST02";

        /// <summary>
        /// ZAADJUST03.
        /// </summary>
        public const string ZAADJUST03 = "ZAADJUST03";

        /// <summary>
        /// ZAADJUST04.
        /// </summary>
        public const string ZAADJUST04 = "ZAADJUST04";

        /// <summary>
        /// ZAADJUST05.
        /// </summary>
        public const string ZAADJUST05 = "ZAADJUST05";

        /// <summary>
        /// ZAADJUST06.
        /// </summary>
        public const string ZAADJUST06 = "ZAADJUST06";

        /// <summary>
        /// ZAADJUST07.
        /// </summary>
        public const string ZAADJUST07 = "ZAADJUST07";

        /// <summary>
        /// ZAADJUST08.
        /// </summary>
        public const string ZAADJUST08 = "ZAADJUST08";

        /// <summary>
        /// ZAUPMJ.
        /// </summary>
        public const string ZAUPMJ = "ZAUPMJ";

        /// <summary>
        /// ZAUPMT.
        /// </summary>
        public const string ZAUPMT = "ZAUPMT";

        /// <summary>
        /// ZAPID.
        /// </summary>
        public const string ZAPID = "ZAPID";

        /// <summary>
        /// ZAJOBN.
        /// </summary>
        public const string ZAJOBN = "ZAJOBN";

        /// <summary>
        /// ZAUSER.
        /// </summary>
        public const string ZAUSER = "ZAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZAEDTF", "ZAEDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAEDTT", "ZAEDTT", JdeDataType.Numeric),
        new JdeField("ZACCPR", "ZACCPR", JdeDataType.String, 6),
        new JdeField("ZASCALE", "ZASCALE", JdeDataType.String, 6, true, true),
        new JdeField("ZALIMIT01", "ZALIMIT01", JdeDataType.Numeric),
        new JdeField("ZALIMIT02", "ZALIMIT02", JdeDataType.Numeric),
        new JdeField("ZALIMIT03", "ZALIMIT03", JdeDataType.Numeric),
        new JdeField("ZALIMIT04", "ZALIMIT04", JdeDataType.Numeric),
        new JdeField("ZALIMIT05", "ZALIMIT05", JdeDataType.Numeric),
        new JdeField("ZALIMIT06", "ZALIMIT06", JdeDataType.Numeric),
        new JdeField("ZALIMIT07", "ZALIMIT07", JdeDataType.Numeric),
        new JdeField("ZALIMIT08", "ZALIMIT08", JdeDataType.Numeric),
        new JdeField("ZATRATE01", "ZATRATE01", JdeDataType.Numeric),
        new JdeField("ZATRATE02", "ZATRATE02", JdeDataType.Numeric),
        new JdeField("ZATRATE03", "ZATRATE03", JdeDataType.Numeric),
        new JdeField("ZATRATE04", "ZATRATE04", JdeDataType.Numeric),
        new JdeField("ZATRATE05", "ZATRATE05", JdeDataType.Numeric),
        new JdeField("ZATRATE06", "ZATRATE06", JdeDataType.Numeric),
        new JdeField("ZATRATE07", "ZATRATE07", JdeDataType.Numeric),
        new JdeField("ZATRATE08", "ZATRATE08", JdeDataType.Numeric),
        new JdeField("ZAADJUST01", "ZAADJUST01", JdeDataType.Numeric),
        new JdeField("ZAADJUST02", "ZAADJUST02", JdeDataType.Numeric),
        new JdeField("ZAADJUST03", "ZAADJUST03", JdeDataType.Numeric),
        new JdeField("ZAADJUST04", "ZAADJUST04", JdeDataType.Numeric),
        new JdeField("ZAADJUST05", "ZAADJUST05", JdeDataType.Numeric),
        new JdeField("ZAADJUST06", "ZAADJUST06", JdeDataType.Numeric),
        new JdeField("ZAADJUST07", "ZAADJUST07", JdeDataType.Numeric),
        new JdeField("ZAADJUST08", "ZAADJUST08", JdeDataType.Numeric),
        new JdeField("ZAUPMJ", "ZAUPMJ", JdeDataType.Numeric),
        new JdeField("ZAUPMT", "ZAUPMT", JdeDataType.Numeric),
        new JdeField("ZAPID", "ZAPID", JdeDataType.String, 20),
        new JdeField("ZAJOBN", "ZAJOBN", JdeDataType.String, 20),
        new JdeField("ZAUSER", "ZAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0001_0", "Primary Key on ZAEDTF, ZASCALE", new[] { "ZAEDTF", "ZASCALE" }, isUnique: true, isPrimaryKey: true)
    };
}
