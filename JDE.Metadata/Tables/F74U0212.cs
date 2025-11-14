using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0212 - .
/// </summary>
public class F74U0212 : JdeTable
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
        /// P874UACPL.
        /// </summary>
        public const string P874UACPL = "P874UACPL";

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
        /// P874UCRCD.
        /// </summary>
        public const string P874UCRCD = "P874UCRCD";

        /// <summary>
        /// P8CRR.
        /// </summary>
        public const string P8CRR = "P8CRR";

        /// <summary>
        /// P874UFROM.
        /// </summary>
        public const string P874UFROM = "P874UFROM";

        /// <summary>
        /// P874UGJD.
        /// </summary>
        public const string P874UGJD = "P874UGJD";

        /// <summary>
        /// P874UGAMT.
        /// </summary>
        public const string P874UGAMT = "P874UGAMT";

        /// <summary>
        /// P874USTA.
        /// </summary>
        public const string P874USTA = "P874USTA";

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
        /// P8DGJ.
        /// </summary>
        public const string P8DGJ = "P8DGJ";

        /// <summary>
        /// P874UCANR.
        /// </summary>
        public const string P874UCANR = "P874UCANR";

        /// <summary>
        /// P8FY.
        /// </summary>
        public const string P8FY = "P8FY";

        /// <summary>
        /// P8CTRY.
        /// </summary>
        public const string P8CTRY = "P8CTRY";

        /// <summary>
        /// P8URCD.
        /// </summary>
        public const string P8URCD = "P8URCD";

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
    public override string TableName => "F74U0212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P8LNID", "P8LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P8DOCO", "P8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P874UACPL", "P874UACPL", JdeDataType.Numeric, null, true, true),
        new JdeField("P874UGENT", "P874UGENT", JdeDataType.String, 2),
        new JdeField("P874UGLC", "P874UGLC", JdeDataType.String, 8),
        new JdeField("P8LSVR", "P8LSVR", JdeDataType.Numeric),
        new JdeField("P8TXA1", "P8TXA1", JdeDataType.String, 20),
        new JdeField("P8EXR1", "P8EXR1", JdeDataType.String, 4),
        new JdeField("P874UCRCD", "P874UCRCD", JdeDataType.String, 6),
        new JdeField("P8CRR", "P8CRR", JdeDataType.Numeric),
        new JdeField("P874UFROM", "P874UFROM", JdeDataType.Numeric),
        new JdeField("P874UGJD", "P874UGJD", JdeDataType.Numeric),
        new JdeField("P874UGAMT", "P874UGAMT", JdeDataType.Numeric),
        new JdeField("P874USTA", "P874USTA", JdeDataType.String, 2),
        new JdeField("P874UCPLD", "P874UCPLD", JdeDataType.Numeric),
        new JdeField("P874UTIMC", "P874UTIMC", JdeDataType.Numeric),
        new JdeField("P8KCO", "P8KCO", JdeDataType.String, 10),
        new JdeField("P8DOC", "P8DOC", JdeDataType.Numeric),
        new JdeField("P8DCT", "P8DCT", JdeDataType.String, 4),
        new JdeField("P8DGJ", "P8DGJ", JdeDataType.Numeric),
        new JdeField("P874UCANR", "P874UCANR", JdeDataType.String, 6),
        new JdeField("P8FY", "P8FY", JdeDataType.Numeric),
        new JdeField("P8CTRY", "P8CTRY", JdeDataType.Numeric),
        new JdeField("P8URCD", "P8URCD", JdeDataType.String, 4),
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
        new JdeIndex("F74U0212_0", "Primary Key on P8LNID, P8DOCO, P874UACPL", new[] { "P8LNID", "P8DOCO", "P874UACPL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0212_2", "Index on SYS_NC00033$, SYS_NC00034$, SYS_NC00035$", new[] { "SYS_NC00033$", "SYS_NC00034$", "SYS_NC00035$" })
    };
}
