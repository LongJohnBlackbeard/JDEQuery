using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47173 - .
/// </summary>
public class F47173 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESEDTY.
        /// </summary>
        public const string ESEDTY = "ESEDTY";

        /// <summary>
        /// ESEDSQ.
        /// </summary>
        public const string ESEDSQ = "ESEDSQ";

        /// <summary>
        /// ESEKCO.
        /// </summary>
        public const string ESEKCO = "ESEKCO";

        /// <summary>
        /// ESEDOC.
        /// </summary>
        public const string ESEDOC = "ESEDOC";

        /// <summary>
        /// ESEDCT.
        /// </summary>
        public const string ESEDCT = "ESEDCT";

        /// <summary>
        /// ESEDLN.
        /// </summary>
        public const string ESEDLN = "ESEDLN";

        /// <summary>
        /// ESEDST.
        /// </summary>
        public const string ESEDST = "ESEDST";

        /// <summary>
        /// ESEDFT.
        /// </summary>
        public const string ESEDFT = "ESEDFT";

        /// <summary>
        /// ESEDDT.
        /// </summary>
        public const string ESEDDT = "ESEDDT";

        /// <summary>
        /// ESEDER.
        /// </summary>
        public const string ESEDER = "ESEDER";

        /// <summary>
        /// ESEDDL.
        /// </summary>
        public const string ESEDDL = "ESEDDL";

        /// <summary>
        /// ESEDSP.
        /// </summary>
        public const string ESEDSP = "ESEDSP";

        /// <summary>
        /// ESEDBT.
        /// </summary>
        public const string ESEDBT = "ESEDBT";

        /// <summary>
        /// ESEDSLN.
        /// </summary>
        public const string ESEDSLN = "ESEDSLN";

        /// <summary>
        /// ESREQFRQ.
        /// </summary>
        public const string ESREQFRQ = "ESREQFRQ";

        /// <summary>
        /// ESCSTDMDPT.
        /// </summary>
        public const string ESCSTDMDPT = "ESCSTDMDPT";

        /// <summary>
        /// ESREQTYP.
        /// </summary>
        public const string ESREQTYP = "ESREQTYP";

        /// <summary>
        /// ESRSDJ.
        /// </summary>
        public const string ESRSDJ = "ESRSDJ";

        /// <summary>
        /// ESRSDT.
        /// </summary>
        public const string ESRSDT = "ESRSDT";

        /// <summary>
        /// ESPSIG.
        /// </summary>
        public const string ESPSIG = "ESPSIG";

        /// <summary>
        /// ESRQSJ.
        /// </summary>
        public const string ESRQSJ = "ESRQSJ";

        /// <summary>
        /// ESRQSHPQTY.
        /// </summary>
        public const string ESRQSHPQTY = "ESRQSHPQTY";

        /// <summary>
        /// ESUOM.
        /// </summary>
        public const string ESUOM = "ESUOM";

        /// <summary>
        /// ESRSHT.
        /// </summary>
        public const string ESRSHT = "ESRSHT";

        /// <summary>
        /// ESERQSHPDJ.
        /// </summary>
        public const string ESERQSHPDJ = "ESERQSHPDJ";

        /// <summary>
        /// ESDMD06.
        /// </summary>
        public const string ESDMD06 = "ESDMD06";

        /// <summary>
        /// ESDMD07.
        /// </summary>
        public const string ESDMD07 = "ESDMD07";

        /// <summary>
        /// ESDMD08.
        /// </summary>
        public const string ESDMD08 = "ESDMD08";

        /// <summary>
        /// ESDMD09.
        /// </summary>
        public const string ESDMD09 = "ESDMD09";

        /// <summary>
        /// ESDMD10.
        /// </summary>
        public const string ESDMD10 = "ESDMD10";

        /// <summary>
        /// ESURCD.
        /// </summary>
        public const string ESURCD = "ESURCD";

        /// <summary>
        /// ESURDT.
        /// </summary>
        public const string ESURDT = "ESURDT";

        /// <summary>
        /// ESURAT.
        /// </summary>
        public const string ESURAT = "ESURAT";

        /// <summary>
        /// ESURAB.
        /// </summary>
        public const string ESURAB = "ESURAB";

        /// <summary>
        /// ESURRF.
        /// </summary>
        public const string ESURRF = "ESURRF";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESTDAY.
        /// </summary>
        public const string ESTDAY = "ESTDAY";

        /// <summary>
        /// ESPSJOBNO.
        /// </summary>
        public const string ESPSJOBNO = "ESPSJOBNO";

        /// <summary>
        /// ESJOBSQ.
        /// </summary>
        public const string ESJOBSQ = "ESJOBSQ";

        /// <summary>
        /// ESDELBATCH.
        /// </summary>
        public const string ESDELBATCH = "ESDELBATCH";
    }

    /// <inheritdoc />
    public override string TableName => "F47173";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESEDTY", "ESEDTY", JdeDataType.String, 2),
        new JdeField("ESEDSQ", "ESEDSQ", JdeDataType.Numeric),
        new JdeField("ESEKCO", "ESEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ESEDOC", "ESEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ESEDCT", "ESEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ESEDLN", "ESEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ESEDST", "ESEDST", JdeDataType.String, 12),
        new JdeField("ESEDFT", "ESEDFT", JdeDataType.String, 20),
        new JdeField("ESEDDT", "ESEDDT", JdeDataType.Numeric),
        new JdeField("ESEDER", "ESEDER", JdeDataType.String, 2),
        new JdeField("ESEDDL", "ESEDDL", JdeDataType.Numeric),
        new JdeField("ESEDSP", "ESEDSP", JdeDataType.String, 2),
        new JdeField("ESEDBT", "ESEDBT", JdeDataType.String, 30),
        new JdeField("ESEDSLN", "ESEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ESREQFRQ", "ESREQFRQ", JdeDataType.String, 6),
        new JdeField("ESCSTDMDPT", "ESCSTDMDPT", JdeDataType.String, 6),
        new JdeField("ESREQTYP", "ESREQTYP", JdeDataType.String, 6),
        new JdeField("ESRSDJ", "ESRSDJ", JdeDataType.Numeric),
        new JdeField("ESRSDT", "ESRSDT", JdeDataType.Numeric),
        new JdeField("ESPSIG", "ESPSIG", JdeDataType.String, 60),
        new JdeField("ESRQSJ", "ESRQSJ", JdeDataType.Numeric),
        new JdeField("ESRQSHPQTY", "ESRQSHPQTY", JdeDataType.Numeric),
        new JdeField("ESUOM", "ESUOM", JdeDataType.String, 4),
        new JdeField("ESRSHT", "ESRSHT", JdeDataType.Numeric),
        new JdeField("ESERQSHPDJ", "ESERQSHPDJ", JdeDataType.Numeric),
        new JdeField("ESDMD06", "ESDMD06", JdeDataType.String, 6),
        new JdeField("ESDMD07", "ESDMD07", JdeDataType.String, 6),
        new JdeField("ESDMD08", "ESDMD08", JdeDataType.String, 6),
        new JdeField("ESDMD09", "ESDMD09", JdeDataType.String, 6),
        new JdeField("ESDMD10", "ESDMD10", JdeDataType.String, 6),
        new JdeField("ESURCD", "ESURCD", JdeDataType.String, 4),
        new JdeField("ESURDT", "ESURDT", JdeDataType.Numeric),
        new JdeField("ESURAT", "ESURAT", JdeDataType.Numeric),
        new JdeField("ESURAB", "ESURAB", JdeDataType.Numeric),
        new JdeField("ESURRF", "ESURRF", JdeDataType.String, 30),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESTDAY", "ESTDAY", JdeDataType.Numeric),
        new JdeField("ESPSJOBNO", "ESPSJOBNO", JdeDataType.String, 30),
        new JdeField("ESJOBSQ", "ESJOBSQ", JdeDataType.String, 30),
        new JdeField("ESDELBATCH", "ESDELBATCH", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47173_0", "Primary Key on ESEDOC, ESEDCT, ESEKCO, ESEDLN, ESEDSLN", new[] { "ESEDOC", "ESEDCT", "ESEKCO", "ESEDLN", "ESEDSLN" }, isUnique: true, isPrimaryKey: true)
    };
}
