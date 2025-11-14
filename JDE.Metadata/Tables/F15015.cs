using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15015 - .
/// </summary>
public class F15015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NQDOCO.
        /// </summary>
        public const string NQDOCO = "NQDOCO";

        /// <summary>
        /// NQDCTO.
        /// </summary>
        public const string NQDCTO = "NQDCTO";

        /// <summary>
        /// NQSOTY.
        /// </summary>
        public const string NQSOTY = "NQSOTY";

        /// <summary>
        /// NQEFTB.
        /// </summary>
        public const string NQEFTB = "NQEFTB";

        /// <summary>
        /// NQEFTE.
        /// </summary>
        public const string NQEFTE = "NQEFTE";

        /// <summary>
        /// NQDL01.
        /// </summary>
        public const string NQDL01 = "NQDL01";

        /// <summary>
        /// NQGLCR.
        /// </summary>
        public const string NQGLCR = "NQGLCR";

        /// <summary>
        /// NQGLC.
        /// </summary>
        public const string NQGLC = "NQGLC";

        /// <summary>
        /// NQMCU.
        /// </summary>
        public const string NQMCU = "NQMCU";

        /// <summary>
        /// NQUNIT.
        /// </summary>
        public const string NQUNIT = "NQUNIT";

        /// <summary>
        /// NQAG.
        /// </summary>
        public const string NQAG = "NQAG";

        /// <summary>
        /// NQDEAL.
        /// </summary>
        public const string NQDEAL = "NQDEAL";

        /// <summary>
        /// NQUSER.
        /// </summary>
        public const string NQUSER = "NQUSER";

        /// <summary>
        /// NQUPMJ.
        /// </summary>
        public const string NQUPMJ = "NQUPMJ";

        /// <summary>
        /// NQPID.
        /// </summary>
        public const string NQPID = "NQPID";

        /// <summary>
        /// NQJOBN.
        /// </summary>
        public const string NQJOBN = "NQJOBN";

        /// <summary>
        /// NQDBAN.
        /// </summary>
        public const string NQDBAN = "NQDBAN";

        /// <summary>
        /// NQYEOV.
        /// </summary>
        public const string NQYEOV = "NQYEOV";

        /// <summary>
        /// NQPSQC.
        /// </summary>
        public const string NQPSQC = "NQPSQC";

        /// <summary>
        /// NQLPCD.
        /// </summary>
        public const string NQLPCD = "NQLPCD";

        /// <summary>
        /// NQPCFD.
        /// </summary>
        public const string NQPCFD = "NQPCFD";

        /// <summary>
        /// NQBCI.
        /// </summary>
        public const string NQBCI = "NQBCI";

        /// <summary>
        /// NQRPCR.
        /// </summary>
        public const string NQRPCR = "NQRPCR";

        /// <summary>
        /// NQRPCL.
        /// </summary>
        public const string NQRPCL = "NQRPCL";

        /// <summary>
        /// NQRCLA.
        /// </summary>
        public const string NQRCLA = "NQRCLA";

        /// <summary>
        /// NQBLFC.
        /// </summary>
        public const string NQBLFC = "NQBLFC";

        /// <summary>
        /// NQBF01.
        /// </summary>
        public const string NQBF01 = "NQBF01";

        /// <summary>
        /// NQBF02.
        /// </summary>
        public const string NQBF02 = "NQBF02";

        /// <summary>
        /// NQBF03.
        /// </summary>
        public const string NQBF03 = "NQBF03";

        /// <summary>
        /// NQBF04.
        /// </summary>
        public const string NQBF04 = "NQBF04";

        /// <summary>
        /// NQBF05.
        /// </summary>
        public const string NQBF05 = "NQBF05";

        /// <summary>
        /// NQBF06.
        /// </summary>
        public const string NQBF06 = "NQBF06";

        /// <summary>
        /// NQBF07.
        /// </summary>
        public const string NQBF07 = "NQBF07";

        /// <summary>
        /// NQBF08.
        /// </summary>
        public const string NQBF08 = "NQBF08";

        /// <summary>
        /// NQBF09.
        /// </summary>
        public const string NQBF09 = "NQBF09";

        /// <summary>
        /// NQBF10.
        /// </summary>
        public const string NQBF10 = "NQBF10";

        /// <summary>
        /// NQBF11.
        /// </summary>
        public const string NQBF11 = "NQBF11";

        /// <summary>
        /// NQBF12.
        /// </summary>
        public const string NQBF12 = "NQBF12";

        /// <summary>
        /// NQBF13.
        /// </summary>
        public const string NQBF13 = "NQBF13";

        /// <summary>
        /// NQUPMT.
        /// </summary>
        public const string NQUPMT = "NQUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NQDOCO", "NQDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NQDCTO", "NQDCTO", JdeDataType.String, 4),
        new JdeField("NQSOTY", "NQSOTY", JdeDataType.String, 4, true, true),
        new JdeField("NQEFTB", "NQEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("NQEFTE", "NQEFTE", JdeDataType.Numeric),
        new JdeField("NQDL01", "NQDL01", JdeDataType.String, 60),
        new JdeField("NQGLCR", "NQGLCR", JdeDataType.String, 8),
        new JdeField("NQGLC", "NQGLC", JdeDataType.String, 8),
        new JdeField("NQMCU", "NQMCU", JdeDataType.String, 24),
        new JdeField("NQUNIT", "NQUNIT", JdeDataType.String, 16),
        new JdeField("NQAG", "NQAG", JdeDataType.Numeric),
        new JdeField("NQDEAL", "NQDEAL", JdeDataType.String, 16),
        new JdeField("NQUSER", "NQUSER", JdeDataType.String, 20),
        new JdeField("NQUPMJ", "NQUPMJ", JdeDataType.Numeric),
        new JdeField("NQPID", "NQPID", JdeDataType.String, 20),
        new JdeField("NQJOBN", "NQJOBN", JdeDataType.String, 20),
        new JdeField("NQDBAN", "NQDBAN", JdeDataType.Numeric),
        new JdeField("NQYEOV", "NQYEOV", JdeDataType.String, 2, true, true),
        new JdeField("NQPSQC", "NQPSQC", JdeDataType.String, 6, true, true),
        new JdeField("NQLPCD", "NQLPCD", JdeDataType.String, 2),
        new JdeField("NQPCFD", "NQPCFD", JdeDataType.String, 2),
        new JdeField("NQBCI", "NQBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NQRPCR", "NQRPCR", JdeDataType.Numeric),
        new JdeField("NQRPCL", "NQRPCL", JdeDataType.Numeric),
        new JdeField("NQRCLA", "NQRCLA", JdeDataType.Numeric),
        new JdeField("NQBLFC", "NQBLFC", JdeDataType.String, 2),
        new JdeField("NQBF01", "NQBF01", JdeDataType.String, 2),
        new JdeField("NQBF02", "NQBF02", JdeDataType.String, 2),
        new JdeField("NQBF03", "NQBF03", JdeDataType.String, 2),
        new JdeField("NQBF04", "NQBF04", JdeDataType.String, 2),
        new JdeField("NQBF05", "NQBF05", JdeDataType.String, 2),
        new JdeField("NQBF06", "NQBF06", JdeDataType.String, 2),
        new JdeField("NQBF07", "NQBF07", JdeDataType.String, 2),
        new JdeField("NQBF08", "NQBF08", JdeDataType.String, 2),
        new JdeField("NQBF09", "NQBF09", JdeDataType.String, 2),
        new JdeField("NQBF10", "NQBF10", JdeDataType.String, 2),
        new JdeField("NQBF11", "NQBF11", JdeDataType.String, 2),
        new JdeField("NQBF12", "NQBF12", JdeDataType.String, 2),
        new JdeField("NQBF13", "NQBF13", JdeDataType.String, 2),
        new JdeField("NQUPMT", "NQUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15015_0", "Primary Key on NQDOCO, NQYEOV, NQPSQC, NQSOTY, NQEFTB, NQBCI", new[] { "NQDOCO", "NQYEOV", "NQPSQC", "NQSOTY", "NQEFTB", "NQBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
