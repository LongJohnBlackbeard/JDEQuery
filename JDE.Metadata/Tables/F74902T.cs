using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74902T - .
/// </summary>
public class F74902T : JdeTable
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
        /// ATK74AD01.
        /// </summary>
        public const string ATK74AD01 = "ATK74AD01";

        /// <summary>
        /// ATK74AD02.
        /// </summary>
        public const string ATK74AD02 = "ATK74AD02";

        /// <summary>
        /// ATK74AD03.
        /// </summary>
        public const string ATK74AD03 = "ATK74AD03";

        /// <summary>
        /// ATK74AD04.
        /// </summary>
        public const string ATK74AD04 = "ATK74AD04";

        /// <summary>
        /// ATK74AD05.
        /// </summary>
        public const string ATK74AD05 = "ATK74AD05";

        /// <summary>
        /// ATK74AD06.
        /// </summary>
        public const string ATK74AD06 = "ATK74AD06";

        /// <summary>
        /// ATK74AD07.
        /// </summary>
        public const string ATK74AD07 = "ATK74AD07";

        /// <summary>
        /// ATK74AD08.
        /// </summary>
        public const string ATK74AD08 = "ATK74AD08";

        /// <summary>
        /// ATK74AD09.
        /// </summary>
        public const string ATK74AD09 = "ATK74AD09";

        /// <summary>
        /// ATK74AD10.
        /// </summary>
        public const string ATK74AD10 = "ATK74AD10";

        /// <summary>
        /// ATK74AD11.
        /// </summary>
        public const string ATK74AD11 = "ATK74AD11";

        /// <summary>
        /// ATK74AD12.
        /// </summary>
        public const string ATK74AD12 = "ATK74AD12";

        /// <summary>
        /// ATK74AD13.
        /// </summary>
        public const string ATK74AD13 = "ATK74AD13";

        /// <summary>
        /// ATK74AD14.
        /// </summary>
        public const string ATK74AD14 = "ATK74AD14";

        /// <summary>
        /// ATK74AC01.
        /// </summary>
        public const string ATK74AC01 = "ATK74AC01";

        /// <summary>
        /// ATK74AC02.
        /// </summary>
        public const string ATK74AC02 = "ATK74AC02";

        /// <summary>
        /// ATK74AC03.
        /// </summary>
        public const string ATK74AC03 = "ATK74AC03";

        /// <summary>
        /// ATK74AC04.
        /// </summary>
        public const string ATK74AC04 = "ATK74AC04";

        /// <summary>
        /// ATK74AC05.
        /// </summary>
        public const string ATK74AC05 = "ATK74AC05";

        /// <summary>
        /// ATK74AC06.
        /// </summary>
        public const string ATK74AC06 = "ATK74AC06";

        /// <summary>
        /// ATK74AC07.
        /// </summary>
        public const string ATK74AC07 = "ATK74AC07";

        /// <summary>
        /// ATK74AC08.
        /// </summary>
        public const string ATK74AC08 = "ATK74AC08";

        /// <summary>
        /// ATK74AC09.
        /// </summary>
        public const string ATK74AC09 = "ATK74AC09";

        /// <summary>
        /// ATK74AC10.
        /// </summary>
        public const string ATK74AC10 = "ATK74AC10";

        /// <summary>
        /// ATK74AC11.
        /// </summary>
        public const string ATK74AC11 = "ATK74AC11";

        /// <summary>
        /// ATK74AC12.
        /// </summary>
        public const string ATK74AC12 = "ATK74AC12";

        /// <summary>
        /// ATK74AC13.
        /// </summary>
        public const string ATK74AC13 = "ATK74AC13";

        /// <summary>
        /// ATK74AC14.
        /// </summary>
        public const string ATK74AC14 = "ATK74AC14";

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
    public override string TableName => "F74902T";

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
        new JdeField("ATK74AD01", "ATK74AD01", JdeDataType.Numeric),
        new JdeField("ATK74AD02", "ATK74AD02", JdeDataType.Numeric),
        new JdeField("ATK74AD03", "ATK74AD03", JdeDataType.Numeric),
        new JdeField("ATK74AD04", "ATK74AD04", JdeDataType.Numeric),
        new JdeField("ATK74AD05", "ATK74AD05", JdeDataType.Numeric),
        new JdeField("ATK74AD06", "ATK74AD06", JdeDataType.Numeric),
        new JdeField("ATK74AD07", "ATK74AD07", JdeDataType.Numeric),
        new JdeField("ATK74AD08", "ATK74AD08", JdeDataType.Numeric),
        new JdeField("ATK74AD09", "ATK74AD09", JdeDataType.Numeric),
        new JdeField("ATK74AD10", "ATK74AD10", JdeDataType.Numeric),
        new JdeField("ATK74AD11", "ATK74AD11", JdeDataType.Numeric),
        new JdeField("ATK74AD12", "ATK74AD12", JdeDataType.Numeric),
        new JdeField("ATK74AD13", "ATK74AD13", JdeDataType.Numeric),
        new JdeField("ATK74AD14", "ATK74AD14", JdeDataType.Numeric),
        new JdeField("ATK74AC01", "ATK74AC01", JdeDataType.Numeric),
        new JdeField("ATK74AC02", "ATK74AC02", JdeDataType.Numeric),
        new JdeField("ATK74AC03", "ATK74AC03", JdeDataType.Numeric),
        new JdeField("ATK74AC04", "ATK74AC04", JdeDataType.Numeric),
        new JdeField("ATK74AC05", "ATK74AC05", JdeDataType.Numeric),
        new JdeField("ATK74AC06", "ATK74AC06", JdeDataType.Numeric),
        new JdeField("ATK74AC07", "ATK74AC07", JdeDataType.Numeric),
        new JdeField("ATK74AC08", "ATK74AC08", JdeDataType.Numeric),
        new JdeField("ATK74AC09", "ATK74AC09", JdeDataType.Numeric),
        new JdeField("ATK74AC10", "ATK74AC10", JdeDataType.Numeric),
        new JdeField("ATK74AC11", "ATK74AC11", JdeDataType.Numeric),
        new JdeField("ATK74AC12", "ATK74AC12", JdeDataType.Numeric),
        new JdeField("ATK74AC13", "ATK74AC13", JdeDataType.Numeric),
        new JdeField("ATK74AC14", "ATK74AC14", JdeDataType.Numeric),
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
        new JdeIndex("F74902T_0", "Primary Key on ATAID, ATCTRY, ATFY, ATFQ, ATLT, ATSBL, ATSBLT, ATCRCD", new[] { "ATAID", "ATCTRY", "ATFY", "ATFQ", "ATLT", "ATSBL", "ATSBLT", "ATCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74902T_2", "Index on ATAID, ATCTRY, ATFY, ATFQ, ATLT, ATCRCD", new[] { "ATAID", "ATCTRY", "ATFY", "ATFQ", "ATLT", "ATCRCD" })
    };
}
