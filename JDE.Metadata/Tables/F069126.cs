using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069126 - .
/// </summary>
public class F069126 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YLUN.
        /// </summary>
        public const string YLUN = "YLUN";

        /// <summary>
        /// YLMCU.
        /// </summary>
        public const string YLMCU = "YLMCU";

        /// <summary>
        /// YLEFTB.
        /// </summary>
        public const string YLEFTB = "YLEFTB";

        /// <summary>
        /// YLEFTE.
        /// </summary>
        public const string YLEFTE = "YLEFTE";

        /// <summary>
        /// YLJBCD.
        /// </summary>
        public const string YLJBCD = "YLJBCD";

        /// <summary>
        /// YLJBST.
        /// </summary>
        public const string YLJBST = "YLJBST";

        /// <summary>
        /// YLSHFT.
        /// </summary>
        public const string YLSHFT = "YLSHFT";

        /// <summary>
        /// YLPHRT.
        /// </summary>
        public const string YLPHRT = "YLPHRT";

        /// <summary>
        /// YLPBRT.
        /// </summary>
        public const string YLPBRT = "YLPBRT";

        /// <summary>
        /// YLLF.
        /// </summary>
        public const string YLLF = "YLLF";

        /// <summary>
        /// YLLMTH.
        /// </summary>
        public const string YLLMTH = "YLLMTH";

        /// <summary>
        /// YLPPRT.
        /// </summary>
        public const string YLPPRT = "YLPPRT";

        /// <summary>
        /// YLWAGD.
        /// </summary>
        public const string YLWAGD = "YLWAGD";

        /// <summary>
        /// YLOH1.
        /// </summary>
        public const string YLOH1 = "YLOH1";

        /// <summary>
        /// YLOH2.
        /// </summary>
        public const string YLOH2 = "YLOH2";

        /// <summary>
        /// YLOH3.
        /// </summary>
        public const string YLOH3 = "YLOH3";

        /// <summary>
        /// YLOH4.
        /// </summary>
        public const string YLOH4 = "YLOH4";

        /// <summary>
        /// YLOBJ.
        /// </summary>
        public const string YLOBJ = "YLOBJ";

        /// <summary>
        /// YLUSER.
        /// </summary>
        public const string YLUSER = "YLUSER";

        /// <summary>
        /// YLPID.
        /// </summary>
        public const string YLPID = "YLPID";

        /// <summary>
        /// YLUPMJ.
        /// </summary>
        public const string YLUPMJ = "YLUPMJ";

        /// <summary>
        /// YLWCMP.
        /// </summary>
        public const string YLWCMP = "YLWCMP";

        /// <summary>
        /// YLOR1.
        /// </summary>
        public const string YLOR1 = "YLOR1";

        /// <summary>
        /// YLOR2.
        /// </summary>
        public const string YLOR2 = "YLOR2";

        /// <summary>
        /// YLOR3.
        /// </summary>
        public const string YLOR3 = "YLOR3";

        /// <summary>
        /// YLOR4.
        /// </summary>
        public const string YLOR4 = "YLOR4";

        /// <summary>
        /// YLB2RT.
        /// </summary>
        public const string YLB2RT = "YLB2RT";

        /// <summary>
        /// YLOU1.
        /// </summary>
        public const string YLOU1 = "YLOU1";

        /// <summary>
        /// YLOU2.
        /// </summary>
        public const string YLOU2 = "YLOU2";

        /// <summary>
        /// YLOU3.
        /// </summary>
        public const string YLOU3 = "YLOU3";

        /// <summary>
        /// YLOU4.
        /// </summary>
        public const string YLOU4 = "YLOU4";

        /// <summary>
        /// YLOT1.
        /// </summary>
        public const string YLOT1 = "YLOT1";

        /// <summary>
        /// YLOT2.
        /// </summary>
        public const string YLOT2 = "YLOT2";

        /// <summary>
        /// YLOT3.
        /// </summary>
        public const string YLOT3 = "YLOT3";

        /// <summary>
        /// YLOT4.
        /// </summary>
        public const string YLOT4 = "YLOT4";

        /// <summary>
        /// YLBDRT.
        /// </summary>
        public const string YLBDRT = "YLBDRT";

        /// <summary>
        /// YLWET.
        /// </summary>
        public const string YLWET = "YLWET";

        /// <summary>
        /// YLRBOB.
        /// </summary>
        public const string YLRBOB = "YLRBOB";

        /// <summary>
        /// YLRBO2.
        /// </summary>
        public const string YLRBO2 = "YLRBO2";

        /// <summary>
        /// YLUNRTEEFLG.
        /// </summary>
        public const string YLUNRTEEFLG = "YLUNRTEEFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F069126";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YLUN", "YLUN", JdeDataType.String, 12, true, true),
        new JdeField("YLMCU", "YLMCU", JdeDataType.String, 24, true, true),
        new JdeField("YLEFTB", "YLEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("YLEFTE", "YLEFTE", JdeDataType.Numeric),
        new JdeField("YLJBCD", "YLJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YLJBST", "YLJBST", JdeDataType.String, 8, true, true),
        new JdeField("YLSHFT", "YLSHFT", JdeDataType.String, 2, true, true),
        new JdeField("YLPHRT", "YLPHRT", JdeDataType.Numeric),
        new JdeField("YLPBRT", "YLPBRT", JdeDataType.Numeric),
        new JdeField("YLLF", "YLLF", JdeDataType.Numeric),
        new JdeField("YLLMTH", "YLLMTH", JdeDataType.String, 2),
        new JdeField("YLPPRT", "YLPPRT", JdeDataType.Numeric),
        new JdeField("YLWAGD", "YLWAGD", JdeDataType.String, 40),
        new JdeField("YLOH1", "YLOH1", JdeDataType.Numeric),
        new JdeField("YLOH2", "YLOH2", JdeDataType.Numeric),
        new JdeField("YLOH3", "YLOH3", JdeDataType.Numeric),
        new JdeField("YLOH4", "YLOH4", JdeDataType.Numeric),
        new JdeField("YLOBJ", "YLOBJ", JdeDataType.String, 12),
        new JdeField("YLUSER", "YLUSER", JdeDataType.String, 20),
        new JdeField("YLPID", "YLPID", JdeDataType.String, 20),
        new JdeField("YLUPMJ", "YLUPMJ", JdeDataType.Numeric),
        new JdeField("YLWCMP", "YLWCMP", JdeDataType.String, 8),
        new JdeField("YLOR1", "YLOR1", JdeDataType.Numeric),
        new JdeField("YLOR2", "YLOR2", JdeDataType.Numeric),
        new JdeField("YLOR3", "YLOR3", JdeDataType.Numeric),
        new JdeField("YLOR4", "YLOR4", JdeDataType.Numeric),
        new JdeField("YLB2RT", "YLB2RT", JdeDataType.Numeric),
        new JdeField("YLOU1", "YLOU1", JdeDataType.Numeric),
        new JdeField("YLOU2", "YLOU2", JdeDataType.Numeric),
        new JdeField("YLOU3", "YLOU3", JdeDataType.Numeric),
        new JdeField("YLOU4", "YLOU4", JdeDataType.Numeric),
        new JdeField("YLOT1", "YLOT1", JdeDataType.Numeric),
        new JdeField("YLOT2", "YLOT2", JdeDataType.Numeric),
        new JdeField("YLOT3", "YLOT3", JdeDataType.Numeric),
        new JdeField("YLOT4", "YLOT4", JdeDataType.Numeric),
        new JdeField("YLBDRT", "YLBDRT", JdeDataType.Numeric),
        new JdeField("YLWET", "YLWET", JdeDataType.String, 2),
        new JdeField("YLRBOB", "YLRBOB", JdeDataType.String, 12),
        new JdeField("YLRBO2", "YLRBO2", JdeDataType.String, 12),
        new JdeField("YLUNRTEEFLG", "YLUNRTEEFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069126_0", "Primary Key on YLUN, YLMCU, YLSHFT, YLEFTB, YLJBCD, YLJBST", new[] { "YLUN", "YLMCU", "YLSHFT", "YLEFTB", "YLJBCD", "YLJBST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069126_2", "Index on YLUN, YLMCU, YLSHFT, YLJBCD, YLJBST, YLEFTB", new[] { "YLUN", "YLMCU", "YLSHFT", "YLJBCD", "YLJBST", "YLEFTB" }),
        new JdeIndex("F069126_3", "Index on SYS_NC00041$, YLUN", new[] { "SYS_NC00041$", "YLUN" })
    };
}
