using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F14041 - .
/// </summary>
public class F14041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BZMCU.
        /// </summary>
        public const string BZMCU = "BZMCU";

        /// <summary>
        /// BZAID.
        /// </summary>
        public const string BZAID = "BZAID";

        /// <summary>
        /// BZRVNUM.
        /// </summary>
        public const string BZRVNUM = "BZRVNUM";

        /// <summary>
        /// BZDL01.
        /// </summary>
        public const string BZDL01 = "BZDL01";

        /// <summary>
        /// BZOBJ.
        /// </summary>
        public const string BZOBJ = "BZOBJ";

        /// <summary>
        /// BZSUB.
        /// </summary>
        public const string BZSUB = "BZSUB";

        /// <summary>
        /// BZCO.
        /// </summary>
        public const string BZCO = "BZCO";

        /// <summary>
        /// BZFY.
        /// </summary>
        public const string BZFY = "BZFY";

        /// <summary>
        /// BZCTRY.
        /// </summary>
        public const string BZCTRY = "BZCTRY";

        /// <summary>
        /// BZAA.
        /// </summary>
        public const string BZAA = "BZAA";

        /// <summary>
        /// BZAN01.
        /// </summary>
        public const string BZAN01 = "BZAN01";

        /// <summary>
        /// BZAN02.
        /// </summary>
        public const string BZAN02 = "BZAN02";

        /// <summary>
        /// BZAN03.
        /// </summary>
        public const string BZAN03 = "BZAN03";

        /// <summary>
        /// BZAN04.
        /// </summary>
        public const string BZAN04 = "BZAN04";

        /// <summary>
        /// BZAN05.
        /// </summary>
        public const string BZAN05 = "BZAN05";

        /// <summary>
        /// BZAN06.
        /// </summary>
        public const string BZAN06 = "BZAN06";

        /// <summary>
        /// BZAN07.
        /// </summary>
        public const string BZAN07 = "BZAN07";

        /// <summary>
        /// BZAN08.
        /// </summary>
        public const string BZAN08 = "BZAN08";

        /// <summary>
        /// BZAN09.
        /// </summary>
        public const string BZAN09 = "BZAN09";

        /// <summary>
        /// BZAN10.
        /// </summary>
        public const string BZAN10 = "BZAN10";

        /// <summary>
        /// BZAN11.
        /// </summary>
        public const string BZAN11 = "BZAN11";

        /// <summary>
        /// BZAN12.
        /// </summary>
        public const string BZAN12 = "BZAN12";

        /// <summary>
        /// BZAN13.
        /// </summary>
        public const string BZAN13 = "BZAN13";

        /// <summary>
        /// BZAN14.
        /// </summary>
        public const string BZAN14 = "BZAN14";

        /// <summary>
        /// BZBPC.
        /// </summary>
        public const string BZBPC = "BZBPC";

        /// <summary>
        /// BZLOCKFLG.
        /// </summary>
        public const string BZLOCKFLG = "BZLOCKFLG";

        /// <summary>
        /// BZUSER.
        /// </summary>
        public const string BZUSER = "BZUSER";

        /// <summary>
        /// BZPID.
        /// </summary>
        public const string BZPID = "BZPID";

        /// <summary>
        /// BZJOBN.
        /// </summary>
        public const string BZJOBN = "BZJOBN";

        /// <summary>
        /// BZUPMJ.
        /// </summary>
        public const string BZUPMJ = "BZUPMJ";

        /// <summary>
        /// BZUPMT.
        /// </summary>
        public const string BZUPMT = "BZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F14041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BZMCU", "BZMCU", JdeDataType.String, 24),
        new JdeField("BZAID", "BZAID", JdeDataType.String, 16, true, true),
        new JdeField("BZRVNUM", "BZRVNUM", JdeDataType.String, 20, true, true),
        new JdeField("BZDL01", "BZDL01", JdeDataType.String, 60),
        new JdeField("BZOBJ", "BZOBJ", JdeDataType.String, 12),
        new JdeField("BZSUB", "BZSUB", JdeDataType.String, 16),
        new JdeField("BZCO", "BZCO", JdeDataType.String, 10),
        new JdeField("BZFY", "BZFY", JdeDataType.Numeric, null, true, true),
        new JdeField("BZCTRY", "BZCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("BZAA", "BZAA", JdeDataType.Numeric),
        new JdeField("BZAN01", "BZAN01", JdeDataType.Numeric),
        new JdeField("BZAN02", "BZAN02", JdeDataType.Numeric),
        new JdeField("BZAN03", "BZAN03", JdeDataType.Numeric),
        new JdeField("BZAN04", "BZAN04", JdeDataType.Numeric),
        new JdeField("BZAN05", "BZAN05", JdeDataType.Numeric),
        new JdeField("BZAN06", "BZAN06", JdeDataType.Numeric),
        new JdeField("BZAN07", "BZAN07", JdeDataType.Numeric),
        new JdeField("BZAN08", "BZAN08", JdeDataType.Numeric),
        new JdeField("BZAN09", "BZAN09", JdeDataType.Numeric),
        new JdeField("BZAN10", "BZAN10", JdeDataType.Numeric),
        new JdeField("BZAN11", "BZAN11", JdeDataType.Numeric),
        new JdeField("BZAN12", "BZAN12", JdeDataType.Numeric),
        new JdeField("BZAN13", "BZAN13", JdeDataType.Numeric),
        new JdeField("BZAN14", "BZAN14", JdeDataType.Numeric),
        new JdeField("BZBPC", "BZBPC", JdeDataType.String, 6),
        new JdeField("BZLOCKFLG", "BZLOCKFLG", JdeDataType.String, 2),
        new JdeField("BZUSER", "BZUSER", JdeDataType.String, 20),
        new JdeField("BZPID", "BZPID", JdeDataType.String, 20),
        new JdeField("BZJOBN", "BZJOBN", JdeDataType.String, 20),
        new JdeField("BZUPMJ", "BZUPMJ", JdeDataType.Numeric),
        new JdeField("BZUPMT", "BZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F14041_0", "Primary Key on BZAID, BZRVNUM, BZCTRY, BZFY", new[] { "BZAID", "BZRVNUM", "BZCTRY", "BZFY" }, isUnique: true, isPrimaryKey: true)
    };
}
