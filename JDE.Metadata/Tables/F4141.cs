using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4141 - .
/// </summary>
public class F4141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PJCYNO.
        /// </summary>
        public const string PJCYNO = "PJCYNO";

        /// <summary>
        /// PJCCCD.
        /// </summary>
        public const string PJCCCD = "PJCCCD";

        /// <summary>
        /// PJITM.
        /// </summary>
        public const string PJITM = "PJITM";

        /// <summary>
        /// PJLITM.
        /// </summary>
        public const string PJLITM = "PJLITM";

        /// <summary>
        /// PJAITM.
        /// </summary>
        public const string PJAITM = "PJAITM";

        /// <summary>
        /// PJMCU.
        /// </summary>
        public const string PJMCU = "PJMCU";

        /// <summary>
        /// PJLOCN.
        /// </summary>
        public const string PJLOCN = "PJLOCN";

        /// <summary>
        /// PJLOTN.
        /// </summary>
        public const string PJLOTN = "PJLOTN";

        /// <summary>
        /// PJSTUN.
        /// </summary>
        public const string PJSTUN = "PJSTUN";

        /// <summary>
        /// PJSRP1.
        /// </summary>
        public const string PJSRP1 = "PJSRP1";

        /// <summary>
        /// PJSRP2.
        /// </summary>
        public const string PJSRP2 = "PJSRP2";

        /// <summary>
        /// PJSRP3.
        /// </summary>
        public const string PJSRP3 = "PJSRP3";

        /// <summary>
        /// PJSRP4.
        /// </summary>
        public const string PJSRP4 = "PJSRP4";

        /// <summary>
        /// PJSRP5.
        /// </summary>
        public const string PJSRP5 = "PJSRP5";

        /// <summary>
        /// PJGLPT.
        /// </summary>
        public const string PJGLPT = "PJGLPT";

        /// <summary>
        /// PJTQOH.
        /// </summary>
        public const string PJTQOH = "PJTQOH";

        /// <summary>
        /// PJTAOH.
        /// </summary>
        public const string PJTAOH = "PJTAOH";

        /// <summary>
        /// PJTQCT.
        /// </summary>
        public const string PJTQCT = "PJTQCT";

        /// <summary>
        /// PJTACT.
        /// </summary>
        public const string PJTACT = "PJTACT";

        /// <summary>
        /// PJUNCS.
        /// </summary>
        public const string PJUNCS = "PJUNCS";

        /// <summary>
        /// PJCNTJ.
        /// </summary>
        public const string PJCNTJ = "PJCNTJ";

        /// <summary>
        /// PJCNTB.
        /// </summary>
        public const string PJCNTB = "PJCNTB";

        /// <summary>
        /// PJAISL.
        /// </summary>
        public const string PJAISL = "PJAISL";

        /// <summary>
        /// PJBIN.
        /// </summary>
        public const string PJBIN = "PJBIN";

        /// <summary>
        /// PJUSER.
        /// </summary>
        public const string PJUSER = "PJUSER";

        /// <summary>
        /// PJPID.
        /// </summary>
        public const string PJPID = "PJPID";

        /// <summary>
        /// PJUPMJ.
        /// </summary>
        public const string PJUPMJ = "PJUPMJ";

        /// <summary>
        /// PJJOBN.
        /// </summary>
        public const string PJJOBN = "PJJOBN";

        /// <summary>
        /// PJTDAY.
        /// </summary>
        public const string PJTDAY = "PJTDAY";

        /// <summary>
        /// PJLOT1.
        /// </summary>
        public const string PJLOT1 = "PJLOT1";

        /// <summary>
        /// PJLOT2.
        /// </summary>
        public const string PJLOT2 = "PJLOT2";

        /// <summary>
        /// PJLOT3.
        /// </summary>
        public const string PJLOT3 = "PJLOT3";

        /// <summary>
        /// PJSQOR.
        /// </summary>
        public const string PJSQOR = "PJSQOR";

        /// <summary>
        /// PJSQOH.
        /// </summary>
        public const string PJSQOH = "PJSQOH";
    }

    /// <inheritdoc />
    public override string TableName => "F4141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PJCYNO", "PJCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PJCCCD", "PJCCCD", JdeDataType.String, 2),
        new JdeField("PJITM", "PJITM", JdeDataType.Numeric),
        new JdeField("PJLITM", "PJLITM", JdeDataType.String, 50, true, true),
        new JdeField("PJAITM", "PJAITM", JdeDataType.String, 50),
        new JdeField("PJMCU", "PJMCU", JdeDataType.String, 24, true, true),
        new JdeField("PJLOCN", "PJLOCN", JdeDataType.String, 40, true, true),
        new JdeField("PJLOTN", "PJLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PJSTUN", "PJSTUN", JdeDataType.Numeric, null, true, true),
        new JdeField("PJSRP1", "PJSRP1", JdeDataType.String, 6),
        new JdeField("PJSRP2", "PJSRP2", JdeDataType.String, 6),
        new JdeField("PJSRP3", "PJSRP3", JdeDataType.String, 6),
        new JdeField("PJSRP4", "PJSRP4", JdeDataType.String, 6),
        new JdeField("PJSRP5", "PJSRP5", JdeDataType.String, 6),
        new JdeField("PJGLPT", "PJGLPT", JdeDataType.String, 8),
        new JdeField("PJTQOH", "PJTQOH", JdeDataType.Numeric),
        new JdeField("PJTAOH", "PJTAOH", JdeDataType.Numeric),
        new JdeField("PJTQCT", "PJTQCT", JdeDataType.Numeric),
        new JdeField("PJTACT", "PJTACT", JdeDataType.Numeric),
        new JdeField("PJUNCS", "PJUNCS", JdeDataType.Numeric),
        new JdeField("PJCNTJ", "PJCNTJ", JdeDataType.Numeric),
        new JdeField("PJCNTB", "PJCNTB", JdeDataType.String, 20),
        new JdeField("PJAISL", "PJAISL", JdeDataType.String, 16),
        new JdeField("PJBIN", "PJBIN", JdeDataType.String, 16),
        new JdeField("PJUSER", "PJUSER", JdeDataType.String, 20),
        new JdeField("PJPID", "PJPID", JdeDataType.String, 20),
        new JdeField("PJUPMJ", "PJUPMJ", JdeDataType.Numeric),
        new JdeField("PJJOBN", "PJJOBN", JdeDataType.String, 20),
        new JdeField("PJTDAY", "PJTDAY", JdeDataType.Numeric),
        new JdeField("PJLOT1", "PJLOT1", JdeDataType.String, 60),
        new JdeField("PJLOT2", "PJLOT2", JdeDataType.String, 60),
        new JdeField("PJLOT3", "PJLOT3", JdeDataType.String, 60),
        new JdeField("PJSQOR", "PJSQOR", JdeDataType.Numeric),
        new JdeField("PJSQOH", "PJSQOH", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4141_0", "Primary Key on PJCYNO, PJLITM, PJMCU, PJLOCN, PJLOTN, PJSTUN", new[] { "PJCYNO", "PJLITM", "PJMCU", "PJLOCN", "PJLOTN", "PJSTUN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4141_3", "Index on PJCYNO, PJMCU, PJLOCN, PJLOTN, PJSTUN", new[] { "PJCYNO", "PJMCU", "PJLOCN", "PJLOTN", "PJSTUN" }),
        new JdeIndex("F4141_4", "Index on PJCYNO, PJSRP1, PJSRP2, PJSRP3, PJSRP4, PJSRP5", new[] { "PJCYNO", "PJSRP1", "PJSRP2", "PJSRP3", "PJSRP4", "PJSRP5" }),
        new JdeIndex("F4141_5", "Index on PJCYNO", new[] { "PJCYNO" })
    };
}
