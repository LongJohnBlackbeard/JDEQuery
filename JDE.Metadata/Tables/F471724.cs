using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471724 - .
/// </summary>
public class F471724 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ENEDTY.
        /// </summary>
        public const string ENEDTY = "ENEDTY";

        /// <summary>
        /// ENEDSQ.
        /// </summary>
        public const string ENEDSQ = "ENEDSQ";

        /// <summary>
        /// ENEKCO.
        /// </summary>
        public const string ENEKCO = "ENEKCO";

        /// <summary>
        /// ENEDOC.
        /// </summary>
        public const string ENEDOC = "ENEDOC";

        /// <summary>
        /// ENEDCT.
        /// </summary>
        public const string ENEDCT = "ENEDCT";

        /// <summary>
        /// ENEDLN.
        /// </summary>
        public const string ENEDLN = "ENEDLN";

        /// <summary>
        /// ENEDST.
        /// </summary>
        public const string ENEDST = "ENEDST";

        /// <summary>
        /// ENEDFT.
        /// </summary>
        public const string ENEDFT = "ENEDFT";

        /// <summary>
        /// ENEDDT.
        /// </summary>
        public const string ENEDDT = "ENEDDT";

        /// <summary>
        /// ENEDER.
        /// </summary>
        public const string ENEDER = "ENEDER";

        /// <summary>
        /// ENEDDL.
        /// </summary>
        public const string ENEDDL = "ENEDDL";

        /// <summary>
        /// ENEDSP.
        /// </summary>
        public const string ENEDSP = "ENEDSP";

        /// <summary>
        /// ENEDBT.
        /// </summary>
        public const string ENEDBT = "ENEDBT";

        /// <summary>
        /// ENEDSLN.
        /// </summary>
        public const string ENEDSLN = "ENEDSLN";

        /// <summary>
        /// ENPARTYTYP.
        /// </summary>
        public const string ENPARTYTYP = "ENPARTYTYP";

        /// <summary>
        /// ENCONTTYP.
        /// </summary>
        public const string ENCONTTYP = "ENCONTTYP";

        /// <summary>
        /// ENPHONETYP.
        /// </summary>
        public const string ENPHONETYP = "ENPHONETYP";

        /// <summary>
        /// ENCONTNUM.
        /// </summary>
        public const string ENCONTNUM = "ENCONTNUM";

        /// <summary>
        /// ENURCD.
        /// </summary>
        public const string ENURCD = "ENURCD";

        /// <summary>
        /// ENURDT.
        /// </summary>
        public const string ENURDT = "ENURDT";

        /// <summary>
        /// ENURAT.
        /// </summary>
        public const string ENURAT = "ENURAT";

        /// <summary>
        /// ENURAB.
        /// </summary>
        public const string ENURAB = "ENURAB";

        /// <summary>
        /// ENURRF.
        /// </summary>
        public const string ENURRF = "ENURRF";

        /// <summary>
        /// ENUSER.
        /// </summary>
        public const string ENUSER = "ENUSER";

        /// <summary>
        /// ENPID.
        /// </summary>
        public const string ENPID = "ENPID";

        /// <summary>
        /// ENJOBN.
        /// </summary>
        public const string ENJOBN = "ENJOBN";

        /// <summary>
        /// ENUPMJ.
        /// </summary>
        public const string ENUPMJ = "ENUPMJ";

        /// <summary>
        /// ENTDAY.
        /// </summary>
        public const string ENTDAY = "ENTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F471724";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ENEDTY", "ENEDTY", JdeDataType.String, 2),
        new JdeField("ENEDSQ", "ENEDSQ", JdeDataType.Numeric),
        new JdeField("ENEKCO", "ENEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ENEDOC", "ENEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ENEDCT", "ENEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ENEDLN", "ENEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ENEDST", "ENEDST", JdeDataType.String, 12),
        new JdeField("ENEDFT", "ENEDFT", JdeDataType.String, 20),
        new JdeField("ENEDDT", "ENEDDT", JdeDataType.Numeric),
        new JdeField("ENEDER", "ENEDER", JdeDataType.String, 2),
        new JdeField("ENEDDL", "ENEDDL", JdeDataType.Numeric),
        new JdeField("ENEDSP", "ENEDSP", JdeDataType.String, 2),
        new JdeField("ENEDBT", "ENEDBT", JdeDataType.String, 30),
        new JdeField("ENEDSLN", "ENEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ENPARTYTYP", "ENPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("ENCONTTYP", "ENCONTTYP", JdeDataType.String, 6, true, true),
        new JdeField("ENPHONETYP", "ENPHONETYP", JdeDataType.String, 6, true, true),
        new JdeField("ENCONTNUM", "ENCONTNUM", JdeDataType.String, 60),
        new JdeField("ENURCD", "ENURCD", JdeDataType.String, 4),
        new JdeField("ENURDT", "ENURDT", JdeDataType.Numeric),
        new JdeField("ENURAT", "ENURAT", JdeDataType.Numeric),
        new JdeField("ENURAB", "ENURAB", JdeDataType.Numeric),
        new JdeField("ENURRF", "ENURRF", JdeDataType.String, 30),
        new JdeField("ENUSER", "ENUSER", JdeDataType.String, 20),
        new JdeField("ENPID", "ENPID", JdeDataType.String, 20),
        new JdeField("ENJOBN", "ENJOBN", JdeDataType.String, 20),
        new JdeField("ENUPMJ", "ENUPMJ", JdeDataType.Numeric),
        new JdeField("ENTDAY", "ENTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471724_0", "Primary Key on ENEDOC, ENEDCT, ENEKCO, ENEDLN, ENEDSLN, ENPARTYTYP, ENCONTTYP, ENPHONETYP", new[] { "ENEDOC", "ENEDCT", "ENEKCO", "ENEDLN", "ENEDSLN", "ENPARTYTYP", "ENCONTTYP", "ENPHONETYP" }, isUnique: true, isPrimaryKey: true)
    };
}
