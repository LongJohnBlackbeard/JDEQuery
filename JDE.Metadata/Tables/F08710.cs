using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08710 - .
/// </summary>
public class F08710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESESID.
        /// </summary>
        public const string ESESID = "ESESID";

        /// <summary>
        /// ESAN8.
        /// </summary>
        public const string ESAN8 = "ESAN8";

        /// <summary>
        /// ESSUSTS.
        /// </summary>
        public const string ESSUSTS = "ESSUSTS";

        /// <summary>
        /// ESARVDT.
        /// </summary>
        public const string ESARVDT = "ESARVDT";

        /// <summary>
        /// ESCRTN.
        /// </summary>
        public const string ESCRTN = "ESCRTN";

        /// <summary>
        /// ESSUAC.
        /// </summary>
        public const string ESSUAC = "ESSUAC";

        /// <summary>
        /// ESOFC.
        /// </summary>
        public const string ESOFC = "ESOFC";

        /// <summary>
        /// ESL001.
        /// </summary>
        public const string ESL001 = "ESL001";

        /// <summary>
        /// ESL002.
        /// </summary>
        public const string ESL002 = "ESL002";

        /// <summary>
        /// ESL003.
        /// </summary>
        public const string ESL003 = "ESL003";

        /// <summary>
        /// ESL004.
        /// </summary>
        public const string ESL004 = "ESL004";

        /// <summary>
        /// ESL005.
        /// </summary>
        public const string ESL005 = "ESL005";

        /// <summary>
        /// ESL006.
        /// </summary>
        public const string ESL006 = "ESL006";

        /// <summary>
        /// ESL007.
        /// </summary>
        public const string ESL007 = "ESL007";

        /// <summary>
        /// ESL008.
        /// </summary>
        public const string ESL008 = "ESL008";

        /// <summary>
        /// ESL009.
        /// </summary>
        public const string ESL009 = "ESL009";

        /// <summary>
        /// ESL010.
        /// </summary>
        public const string ESL010 = "ESL010";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESAPRV.
        /// </summary>
        public const string ESAPRV = "ESAPRV";

        /// <summary>
        /// ESANPA.
        /// </summary>
        public const string ESANPA = "ESANPA";
    }

    /// <inheritdoc />
    public override string TableName => "F08710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESESID", "ESESID", JdeDataType.Numeric, null, true, true),
        new JdeField("ESAN8", "ESAN8", JdeDataType.Numeric),
        new JdeField("ESSUSTS", "ESSUSTS", JdeDataType.String, 4),
        new JdeField("ESARVDT", "ESARVDT", JdeDataType.Numeric),
        new JdeField("ESCRTN", "ESCRTN", JdeDataType.Numeric),
        new JdeField("ESSUAC", "ESSUAC", JdeDataType.String, 2),
        new JdeField("ESOFC", "ESOFC", JdeDataType.String, 40),
        new JdeField("ESL001", "ESL001", JdeDataType.String, 20),
        new JdeField("ESL002", "ESL002", JdeDataType.String, 20),
        new JdeField("ESL003", "ESL003", JdeDataType.String, 20),
        new JdeField("ESL004", "ESL004", JdeDataType.String, 20),
        new JdeField("ESL005", "ESL005", JdeDataType.String, 20),
        new JdeField("ESL006", "ESL006", JdeDataType.String, 20),
        new JdeField("ESL007", "ESL007", JdeDataType.String, 20),
        new JdeField("ESL008", "ESL008", JdeDataType.String, 20),
        new JdeField("ESL009", "ESL009", JdeDataType.String, 20),
        new JdeField("ESL010", "ESL010", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESAPRV", "ESAPRV", JdeDataType.Numeric),
        new JdeField("ESANPA", "ESANPA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08710_0", "Primary Key on ESESID", new[] { "ESESID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08710_3", "Index on ESAN8", new[] { "ESAN8" }),
        new JdeIndex("F08710_4", "Index on ESSUSTS", new[] { "ESSUSTS" }),
        new JdeIndex("F08710_5", "Index on ESAPRV", new[] { "ESAPRV" }),
        new JdeIndex("F08710_6", "Index on ESANPA", new[] { "ESANPA" })
    };
}
