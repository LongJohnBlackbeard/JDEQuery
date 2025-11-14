using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW02 - .
/// </summary>
public class FCW02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISC9STRC.
        /// </summary>
        public const string ISC9STRC = "ISC9STRC";

        /// <summary>
        /// ISC9LVNO.
        /// </summary>
        public const string ISC9LVNO = "ISC9LVNO";

        /// <summary>
        /// ISC9LVNM.
        /// </summary>
        public const string ISC9LVNM = "ISC9LVNM";

        /// <summary>
        /// ISC9ITM.
        /// </summary>
        public const string ISC9ITM = "ISC9ITM";

        /// <summary>
        /// ISC9LVCO.
        /// </summary>
        public const string ISC9LVCO = "ISC9LVCO";

        /// <summary>
        /// ISC9PLNM.
        /// </summary>
        public const string ISC9PLNM = "ISC9PLNM";

        /// <summary>
        /// ISC9ITMP.
        /// </summary>
        public const string ISC9ITMP = "ISC9ITMP";

        /// <summary>
        /// ISC9LVL0.
        /// </summary>
        public const string ISC9LVL0 = "ISC9LVL0";

        /// <summary>
        /// ISC9LVL1.
        /// </summary>
        public const string ISC9LVL1 = "ISC9LVL1";

        /// <summary>
        /// ISC9LVL2.
        /// </summary>
        public const string ISC9LVL2 = "ISC9LVL2";

        /// <summary>
        /// ISC9LVL3.
        /// </summary>
        public const string ISC9LVL3 = "ISC9LVL3";

        /// <summary>
        /// ISC9LVL4.
        /// </summary>
        public const string ISC9LVL4 = "ISC9LVL4";

        /// <summary>
        /// ISC9LVL5.
        /// </summary>
        public const string ISC9LVL5 = "ISC9LVL5";

        /// <summary>
        /// ISC9LVL6.
        /// </summary>
        public const string ISC9LVL6 = "ISC9LVL6";

        /// <summary>
        /// ISC9LVL7.
        /// </summary>
        public const string ISC9LVL7 = "ISC9LVL7";

        /// <summary>
        /// ISC9LVL8.
        /// </summary>
        public const string ISC9LVL8 = "ISC9LVL8";

        /// <summary>
        /// ISC9LVL9.
        /// </summary>
        public const string ISC9LVL9 = "ISC9LVL9";

        /// <summary>
        /// ISC9STS.
        /// </summary>
        public const string ISC9STS = "ISC9STS";

        /// <summary>
        /// ISC9MSG.
        /// </summary>
        public const string ISC9MSG = "ISC9MSG";

        /// <summary>
        /// ISC9USER.
        /// </summary>
        public const string ISC9USER = "ISC9USER";

        /// <summary>
        /// ISURCD.
        /// </summary>
        public const string ISURCD = "ISURCD";

        /// <summary>
        /// ISURDT.
        /// </summary>
        public const string ISURDT = "ISURDT";

        /// <summary>
        /// ISURAT.
        /// </summary>
        public const string ISURAT = "ISURAT";

        /// <summary>
        /// ISURAB.
        /// </summary>
        public const string ISURAB = "ISURAB";

        /// <summary>
        /// ISURRF.
        /// </summary>
        public const string ISURRF = "ISURRF";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISTDAY.
        /// </summary>
        public const string ISTDAY = "ISTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISC9STRC", "ISC9STRC", JdeDataType.String, 6, true, true),
        new JdeField("ISC9LVNO", "ISC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("ISC9LVNM", "ISC9LVNM", JdeDataType.String, 100, true, true),
        new JdeField("ISC9ITM", "ISC9ITM", JdeDataType.Numeric),
        new JdeField("ISC9LVCO", "ISC9LVCO", JdeDataType.String, 50),
        new JdeField("ISC9PLNM", "ISC9PLNM", JdeDataType.String, 100),
        new JdeField("ISC9ITMP", "ISC9ITMP", JdeDataType.Numeric),
        new JdeField("ISC9LVL0", "ISC9LVL0", JdeDataType.String, 50),
        new JdeField("ISC9LVL1", "ISC9LVL1", JdeDataType.String, 12),
        new JdeField("ISC9LVL2", "ISC9LVL2", JdeDataType.String, 12),
        new JdeField("ISC9LVL3", "ISC9LVL3", JdeDataType.String, 12),
        new JdeField("ISC9LVL4", "ISC9LVL4", JdeDataType.String, 12),
        new JdeField("ISC9LVL5", "ISC9LVL5", JdeDataType.String, 12),
        new JdeField("ISC9LVL6", "ISC9LVL6", JdeDataType.String, 12),
        new JdeField("ISC9LVL7", "ISC9LVL7", JdeDataType.String, 12),
        new JdeField("ISC9LVL8", "ISC9LVL8", JdeDataType.String, 12),
        new JdeField("ISC9LVL9", "ISC9LVL9", JdeDataType.String, 12),
        new JdeField("ISC9STS", "ISC9STS", JdeDataType.String, 2),
        new JdeField("ISC9MSG", "ISC9MSG", JdeDataType.String, 20),
        new JdeField("ISC9USER", "ISC9USER", JdeDataType.String, 20),
        new JdeField("ISURCD", "ISURCD", JdeDataType.String, 4),
        new JdeField("ISURDT", "ISURDT", JdeDataType.Numeric),
        new JdeField("ISURAT", "ISURAT", JdeDataType.Numeric),
        new JdeField("ISURAB", "ISURAB", JdeDataType.Numeric),
        new JdeField("ISURRF", "ISURRF", JdeDataType.String, 30),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISTDAY", "ISTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW02_0", "Primary Key on ISC9STRC, ISC9LVNO, ISC9LVNM", new[] { "ISC9STRC", "ISC9LVNO", "ISC9LVNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW02_10", "Index on ISC9STRC, ISC9LVL0, SYS_NC00031$, ISC9LVNM", new[] { "ISC9STRC", "ISC9LVL0", "SYS_NC00031$", "ISC9LVNM" }),
        new JdeIndex("FCW02_2", "Index on ISC9STRC, ISC9LVNO, ISC9LVL0, ISC9LVCO", new[] { "ISC9STRC", "ISC9LVNO", "ISC9LVL0", "ISC9LVCO" }),
        new JdeIndex("FCW02_3", "Index on ISC9LVNM", new[] { "ISC9LVNM" }),
        new JdeIndex("FCW02_4", "Index on ISC9STS, ISC9STRC, ISC9LVNO, ISC9LVNM", new[] { "ISC9STS", "ISC9STRC", "ISC9LVNO", "ISC9LVNM" }),
        new JdeIndex("FCW02_5", "Index on ISC9ITM", new[] { "ISC9ITM" }),
        new JdeIndex("FCW02_6", "Index on ISC9PLNM", new[] { "ISC9PLNM" }),
        new JdeIndex("FCW02_7", "Index on ISC9ITMP", new[] { "ISC9ITMP" }),
        new JdeIndex("FCW02_8", "Index on ISC9LVL0, ISC9LVNO", new[] { "ISC9LVL0", "ISC9LVNO" }),
        new JdeIndex("FCW02_9", "Index on ISC9LVL0, ISC9LVL1, ISC9LVL2, ISC9LVL3, ISC9LVL4, ISC9LVL5, ISC9LVL6, ISC9LVL7, ISC9LVL8, ISC9LVL9", new[] { "ISC9LVL0", "ISC9LVL1", "ISC9LVL2", "ISC9LVL3", "ISC9LVL4", "ISC9LVL5", "ISC9LVL6", "ISC9LVL7", "ISC9LVL8", "ISC9LVL9" })
    };
}
