using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0205 - .
/// </summary>
public class F74U0205 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P8LNID.
        /// </summary>
        public const string P8LNID = "P8LNID";

        /// <summary>
        /// P8DOCO.
        /// </summary>
        public const string P8DOCO = "P8DOCO";

        /// <summary>
        /// P874UPPLN.
        /// </summary>
        public const string P874UPPLN = "P874UPPLN";

        /// <summary>
        /// P874UGENT.
        /// </summary>
        public const string P874UGENT = "P874UGENT";

        /// <summary>
        /// P874UGLC.
        /// </summary>
        public const string P874UGLC = "P874UGLC";

        /// <summary>
        /// P8LSVR.
        /// </summary>
        public const string P8LSVR = "P8LSVR";

        /// <summary>
        /// P8TXA1.
        /// </summary>
        public const string P8TXA1 = "P8TXA1";

        /// <summary>
        /// P8EXR1.
        /// </summary>
        public const string P8EXR1 = "P8EXR1";

        /// <summary>
        /// P874UDGEN.
        /// </summary>
        public const string P874UDGEN = "P874UDGEN";

        /// <summary>
        /// P874UFTGD.
        /// </summary>
        public const string P874UFTGD = "P874UFTGD";

        /// <summary>
        /// P874UGAMT.
        /// </summary>
        public const string P874UGAMT = "P874UGAMT";

        /// <summary>
        /// P874USTA.
        /// </summary>
        public const string P874USTA = "P874USTA";

        /// <summary>
        /// P874UCANR.
        /// </summary>
        public const string P874UCANR = "P874UCANR";

        /// <summary>
        /// P874UCPLD.
        /// </summary>
        public const string P874UCPLD = "P874UCPLD";

        /// <summary>
        /// P874UTIMC.
        /// </summary>
        public const string P874UTIMC = "P874UTIMC";

        /// <summary>
        /// P8KCO.
        /// </summary>
        public const string P8KCO = "P8KCO";

        /// <summary>
        /// P8DOC.
        /// </summary>
        public const string P8DOC = "P8DOC";

        /// <summary>
        /// P8DCT.
        /// </summary>
        public const string P8DCT = "P8DCT";

        /// <summary>
        /// P8SFX.
        /// </summary>
        public const string P8SFX = "P8SFX";

        /// <summary>
        /// P8SFXE.
        /// </summary>
        public const string P8SFXE = "P8SFXE";

        /// <summary>
        /// P8IVD.
        /// </summary>
        public const string P8IVD = "P8IVD";

        /// <summary>
        /// P8DGJ.
        /// </summary>
        public const string P8DGJ = "P8DGJ";

        /// <summary>
        /// P874UCRCD.
        /// </summary>
        public const string P874UCRCD = "P874UCRCD";

        /// <summary>
        /// P874UOBR.
        /// </summary>
        public const string P874UOBR = "P874UOBR";

        /// <summary>
        /// P8BCI.
        /// </summary>
        public const string P8BCI = "P8BCI";

        /// <summary>
        /// P874USICU.
        /// </summary>
        public const string P874USICU = "P874USICU";

        /// <summary>
        /// P874UTINT.
        /// </summary>
        public const string P874UTINT = "P874UTINT";

        /// <summary>
        /// P874UADJF.
        /// </summary>
        public const string P874UADJF = "P874UADJF";

        /// <summary>
        /// P8PN.
        /// </summary>
        public const string P8PN = "P8PN";

        /// <summary>
        /// P8MCU.
        /// </summary>
        public const string P8MCU = "P8MCU";

        /// <summary>
        /// P8UNIT.
        /// </summary>
        public const string P8UNIT = "P8UNIT";

        /// <summary>
        /// P8RMK.
        /// </summary>
        public const string P8RMK = "P8RMK";

        /// <summary>
        /// P8EV02.
        /// </summary>
        public const string P8EV02 = "P8EV02";

        /// <summary>
        /// P8URCD.
        /// </summary>
        public const string P8URCD = "P8URCD";

        /// <summary>
        /// P8URDT.
        /// </summary>
        public const string P8URDT = "P8URDT";

        /// <summary>
        /// P8URAT.
        /// </summary>
        public const string P8URAT = "P8URAT";

        /// <summary>
        /// P8URAB.
        /// </summary>
        public const string P8URAB = "P8URAB";

        /// <summary>
        /// P8URRF.
        /// </summary>
        public const string P8URRF = "P8URRF";

        /// <summary>
        /// P8USER.
        /// </summary>
        public const string P8USER = "P8USER";

        /// <summary>
        /// P8PID.
        /// </summary>
        public const string P8PID = "P8PID";

        /// <summary>
        /// P8UPMJ.
        /// </summary>
        public const string P8UPMJ = "P8UPMJ";

        /// <summary>
        /// P8UPMT.
        /// </summary>
        public const string P8UPMT = "P8UPMT";

        /// <summary>
        /// P8JOBN.
        /// </summary>
        public const string P8JOBN = "P8JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0205";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P8LNID", "P8LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P8DOCO", "P8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P874UPPLN", "P874UPPLN", JdeDataType.Numeric, null, true, true),
        new JdeField("P874UGENT", "P874UGENT", JdeDataType.String, 2),
        new JdeField("P874UGLC", "P874UGLC", JdeDataType.String, 8, true, true),
        new JdeField("P8LSVR", "P8LSVR", JdeDataType.Numeric),
        new JdeField("P8TXA1", "P8TXA1", JdeDataType.String, 20),
        new JdeField("P8EXR1", "P8EXR1", JdeDataType.String, 4),
        new JdeField("P874UDGEN", "P874UDGEN", JdeDataType.Numeric),
        new JdeField("P874UFTGD", "P874UFTGD", JdeDataType.Numeric),
        new JdeField("P874UGAMT", "P874UGAMT", JdeDataType.Numeric),
        new JdeField("P874USTA", "P874USTA", JdeDataType.String, 2),
        new JdeField("P874UCANR", "P874UCANR", JdeDataType.String, 6),
        new JdeField("P874UCPLD", "P874UCPLD", JdeDataType.Numeric),
        new JdeField("P874UTIMC", "P874UTIMC", JdeDataType.Numeric),
        new JdeField("P8KCO", "P8KCO", JdeDataType.String, 10),
        new JdeField("P8DOC", "P8DOC", JdeDataType.Numeric),
        new JdeField("P8DCT", "P8DCT", JdeDataType.String, 4),
        new JdeField("P8SFX", "P8SFX", JdeDataType.String, 6),
        new JdeField("P8SFXE", "P8SFXE", JdeDataType.Numeric),
        new JdeField("P8IVD", "P8IVD", JdeDataType.Numeric),
        new JdeField("P8DGJ", "P8DGJ", JdeDataType.Numeric),
        new JdeField("P874UCRCD", "P874UCRCD", JdeDataType.String, 6),
        new JdeField("P874UOBR", "P874UOBR", JdeDataType.Numeric),
        new JdeField("P8BCI", "P8BCI", JdeDataType.Numeric),
        new JdeField("P874USICU", "P874USICU", JdeDataType.Numeric),
        new JdeField("P874UTINT", "P874UTINT", JdeDataType.Numeric),
        new JdeField("P874UADJF", "P874UADJF", JdeDataType.String, 2),
        new JdeField("P8PN", "P8PN", JdeDataType.Numeric),
        new JdeField("P8MCU", "P8MCU", JdeDataType.String, 24),
        new JdeField("P8UNIT", "P8UNIT", JdeDataType.String, 16),
        new JdeField("P8RMK", "P8RMK", JdeDataType.String, 60),
        new JdeField("P8EV02", "P8EV02", JdeDataType.String, 2),
        new JdeField("P8URCD", "P8URCD", JdeDataType.String, 4),
        new JdeField("P8URDT", "P8URDT", JdeDataType.Numeric),
        new JdeField("P8URAT", "P8URAT", JdeDataType.Numeric),
        new JdeField("P8URAB", "P8URAB", JdeDataType.Numeric),
        new JdeField("P8URRF", "P8URRF", JdeDataType.String, 30),
        new JdeField("P8USER", "P8USER", JdeDataType.String, 20),
        new JdeField("P8PID", "P8PID", JdeDataType.String, 20),
        new JdeField("P8UPMJ", "P8UPMJ", JdeDataType.Numeric),
        new JdeField("P8UPMT", "P8UPMT", JdeDataType.Numeric),
        new JdeField("P8JOBN", "P8JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0205_0", "Primary Key on P8DOCO, P8LNID, P874UPPLN, P874UGLC", new[] { "P8DOCO", "P8LNID", "P874UPPLN", "P874UGLC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0205_2", "Index on P8DOCO, P8LNID, P874UGENT", new[] { "P8DOCO", "P8LNID", "P874UGENT" }),
        new JdeIndex("F74U0205_3", "Index on P8DOCO, P8LNID, P874USTA, P874UFTGD", new[] { "P8DOCO", "P8LNID", "P874USTA", "P874UFTGD" }),
        new JdeIndex("F74U0205_4", "Index on P8DOCO, P8LNID, P874USTA, P874UGLC", new[] { "P8DOCO", "P8LNID", "P874USTA", "P874UGLC" }),
        new JdeIndex("F74U0205_5", "Index on P8DOCO, P8LNID, P874UPPLN, P874UGLC, P8KCO, P8DOC, P8DCT, P8SFX", new[] { "P8DOCO", "P8LNID", "P874UPPLN", "P874UGLC", "P8KCO", "P8DOC", "P8DCT", "P8SFX" }),
        new JdeIndex("F74U0205_6", "Index on P8KCO, P8DOC, P8DCT, P8SFX", new[] { "P8KCO", "P8DOC", "P8DCT", "P8SFX" }),
        new JdeIndex("F74U0205_7", "Index on P8DOCO, P8KCO, P8DOC, P8DCT, P8SFX", new[] { "P8DOCO", "P8KCO", "P8DOC", "P8DCT", "P8SFX" })
    };
}
