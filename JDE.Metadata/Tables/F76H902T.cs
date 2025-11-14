using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H902T - .
/// </summary>
public class F76H902T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAID.
        /// </summary>
        public const string ATAID = "ATAID";

        /// <summary>
        /// ATCTRY.
        /// </summary>
        public const string ATCTRY = "ATCTRY";

        /// <summary>
        /// ATFY.
        /// </summary>
        public const string ATFY = "ATFY";

        /// <summary>
        /// ATFQ.
        /// </summary>
        public const string ATFQ = "ATFQ";

        /// <summary>
        /// ATLT.
        /// </summary>
        public const string ATLT = "ATLT";

        /// <summary>
        /// ATSBL.
        /// </summary>
        public const string ATSBL = "ATSBL";

        /// <summary>
        /// ATSBLT.
        /// </summary>
        public const string ATSBLT = "ATSBLT";

        /// <summary>
        /// ATCRCD.
        /// </summary>
        public const string ATCRCD = "ATCRCD";

        /// <summary>
        /// ATH76AD01.
        /// </summary>
        public const string ATH76AD01 = "ATH76AD01";

        /// <summary>
        /// ATH76AD02.
        /// </summary>
        public const string ATH76AD02 = "ATH76AD02";

        /// <summary>
        /// ATH76AD03.
        /// </summary>
        public const string ATH76AD03 = "ATH76AD03";

        /// <summary>
        /// ATH76AD04.
        /// </summary>
        public const string ATH76AD04 = "ATH76AD04";

        /// <summary>
        /// ATH76AD05.
        /// </summary>
        public const string ATH76AD05 = "ATH76AD05";

        /// <summary>
        /// ATH76AD06.
        /// </summary>
        public const string ATH76AD06 = "ATH76AD06";

        /// <summary>
        /// ATH76AD07.
        /// </summary>
        public const string ATH76AD07 = "ATH76AD07";

        /// <summary>
        /// ATH76AD08.
        /// </summary>
        public const string ATH76AD08 = "ATH76AD08";

        /// <summary>
        /// ATH76AD09.
        /// </summary>
        public const string ATH76AD09 = "ATH76AD09";

        /// <summary>
        /// ATH76AD10.
        /// </summary>
        public const string ATH76AD10 = "ATH76AD10";

        /// <summary>
        /// ATH76AD11.
        /// </summary>
        public const string ATH76AD11 = "ATH76AD11";

        /// <summary>
        /// ATH76AD12.
        /// </summary>
        public const string ATH76AD12 = "ATH76AD12";

        /// <summary>
        /// ATH76AD13.
        /// </summary>
        public const string ATH76AD13 = "ATH76AD13";

        /// <summary>
        /// ATH76AD14.
        /// </summary>
        public const string ATH76AD14 = "ATH76AD14";

        /// <summary>
        /// ATH76AC01.
        /// </summary>
        public const string ATH76AC01 = "ATH76AC01";

        /// <summary>
        /// ATH76AC02.
        /// </summary>
        public const string ATH76AC02 = "ATH76AC02";

        /// <summary>
        /// ATH76AC03.
        /// </summary>
        public const string ATH76AC03 = "ATH76AC03";

        /// <summary>
        /// ATH76AC04.
        /// </summary>
        public const string ATH76AC04 = "ATH76AC04";

        /// <summary>
        /// ATH76AC05.
        /// </summary>
        public const string ATH76AC05 = "ATH76AC05";

        /// <summary>
        /// ATH76AC06.
        /// </summary>
        public const string ATH76AC06 = "ATH76AC06";

        /// <summary>
        /// ATH76AC07.
        /// </summary>
        public const string ATH76AC07 = "ATH76AC07";

        /// <summary>
        /// ATH76AC08.
        /// </summary>
        public const string ATH76AC08 = "ATH76AC08";

        /// <summary>
        /// ATH76AC09.
        /// </summary>
        public const string ATH76AC09 = "ATH76AC09";

        /// <summary>
        /// ATH76AC10.
        /// </summary>
        public const string ATH76AC10 = "ATH76AC10";

        /// <summary>
        /// ATH76AC11.
        /// </summary>
        public const string ATH76AC11 = "ATH76AC11";

        /// <summary>
        /// ATH76AC12.
        /// </summary>
        public const string ATH76AC12 = "ATH76AC12";

        /// <summary>
        /// ATH76AC13.
        /// </summary>
        public const string ATH76AC13 = "ATH76AC13";

        /// <summary>
        /// ATH76AC14.
        /// </summary>
        public const string ATH76AC14 = "ATH76AC14";

        /// <summary>
        /// ATCRCX.
        /// </summary>
        public const string ATCRCX = "ATCRCX";

        /// <summary>
        /// ATCO.
        /// </summary>
        public const string ATCO = "ATCO";

        /// <summary>
        /// ATMCU.
        /// </summary>
        public const string ATMCU = "ATMCU";

        /// <summary>
        /// ATOBJ.
        /// </summary>
        public const string ATOBJ = "ATOBJ";

        /// <summary>
        /// ATSUB.
        /// </summary>
        public const string ATSUB = "ATSUB";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATJOBN.
        /// </summary>
        public const string ATJOBN = "ATJOBN";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H902T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAID", "ATAID", JdeDataType.String, 16, true, true),
        new JdeField("ATCTRY", "ATCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ATFY", "ATFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ATFQ", "ATFQ", JdeDataType.String, 8, true, true),
        new JdeField("ATLT", "ATLT", JdeDataType.String, 4, true, true),
        new JdeField("ATSBL", "ATSBL", JdeDataType.String, 16, true, true),
        new JdeField("ATSBLT", "ATSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ATCRCD", "ATCRCD", JdeDataType.String, 6, true, true),
        new JdeField("ATH76AD01", "ATH76AD01", JdeDataType.Numeric),
        new JdeField("ATH76AD02", "ATH76AD02", JdeDataType.Numeric),
        new JdeField("ATH76AD03", "ATH76AD03", JdeDataType.Numeric),
        new JdeField("ATH76AD04", "ATH76AD04", JdeDataType.Numeric),
        new JdeField("ATH76AD05", "ATH76AD05", JdeDataType.Numeric),
        new JdeField("ATH76AD06", "ATH76AD06", JdeDataType.Numeric),
        new JdeField("ATH76AD07", "ATH76AD07", JdeDataType.Numeric),
        new JdeField("ATH76AD08", "ATH76AD08", JdeDataType.Numeric),
        new JdeField("ATH76AD09", "ATH76AD09", JdeDataType.Numeric),
        new JdeField("ATH76AD10", "ATH76AD10", JdeDataType.Numeric),
        new JdeField("ATH76AD11", "ATH76AD11", JdeDataType.Numeric),
        new JdeField("ATH76AD12", "ATH76AD12", JdeDataType.Numeric),
        new JdeField("ATH76AD13", "ATH76AD13", JdeDataType.Numeric),
        new JdeField("ATH76AD14", "ATH76AD14", JdeDataType.Numeric),
        new JdeField("ATH76AC01", "ATH76AC01", JdeDataType.Numeric),
        new JdeField("ATH76AC02", "ATH76AC02", JdeDataType.Numeric),
        new JdeField("ATH76AC03", "ATH76AC03", JdeDataType.Numeric),
        new JdeField("ATH76AC04", "ATH76AC04", JdeDataType.Numeric),
        new JdeField("ATH76AC05", "ATH76AC05", JdeDataType.Numeric),
        new JdeField("ATH76AC06", "ATH76AC06", JdeDataType.Numeric),
        new JdeField("ATH76AC07", "ATH76AC07", JdeDataType.Numeric),
        new JdeField("ATH76AC08", "ATH76AC08", JdeDataType.Numeric),
        new JdeField("ATH76AC09", "ATH76AC09", JdeDataType.Numeric),
        new JdeField("ATH76AC10", "ATH76AC10", JdeDataType.Numeric),
        new JdeField("ATH76AC11", "ATH76AC11", JdeDataType.Numeric),
        new JdeField("ATH76AC12", "ATH76AC12", JdeDataType.Numeric),
        new JdeField("ATH76AC13", "ATH76AC13", JdeDataType.Numeric),
        new JdeField("ATH76AC14", "ATH76AC14", JdeDataType.Numeric),
        new JdeField("ATCRCX", "ATCRCX", JdeDataType.String, 6),
        new JdeField("ATCO", "ATCO", JdeDataType.String, 10),
        new JdeField("ATMCU", "ATMCU", JdeDataType.String, 24),
        new JdeField("ATOBJ", "ATOBJ", JdeDataType.String, 12),
        new JdeField("ATSUB", "ATSUB", JdeDataType.String, 16),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATJOBN", "ATJOBN", JdeDataType.String, 20),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H902T_0", "Primary Key on ATAID, ATCTRY, ATFY, ATFQ, ATLT, ATSBL, ATSBLT, ATCRCD", new[] { "ATAID", "ATCTRY", "ATFY", "ATFQ", "ATLT", "ATSBL", "ATSBLT", "ATCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H902T_2", "Index on ATAID, ATCTRY, ATFY, ATFQ, ATLT, ATCRCD", new[] { "ATAID", "ATCTRY", "ATFY", "ATFQ", "ATLT", "ATCRCD" })
    };
}
