using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470374 - .
/// </summary>
public class F470374 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMEDOC.
        /// </summary>
        public const string AMEDOC = "AMEDOC";

        /// <summary>
        /// AMEDCT.
        /// </summary>
        public const string AMEDCT = "AMEDCT";

        /// <summary>
        /// AMEKCO.
        /// </summary>
        public const string AMEKCO = "AMEKCO";

        /// <summary>
        /// AMEDLN.
        /// </summary>
        public const string AMEDLN = "AMEDLN";

        /// <summary>
        /// AMLINS.
        /// </summary>
        public const string AMLINS = "AMLINS";

        /// <summary>
        /// AMSTPC.
        /// </summary>
        public const string AMSTPC = "AMSTPC";

        /// <summary>
        /// AMANTY.
        /// </summary>
        public const string AMANTY = "AMANTY";

        /// <summary>
        /// AMEDST.
        /// </summary>
        public const string AMEDST = "AMEDST";

        /// <summary>
        /// AMEDFT.
        /// </summary>
        public const string AMEDFT = "AMEDFT";

        /// <summary>
        /// AMEDDT.
        /// </summary>
        public const string AMEDDT = "AMEDDT";

        /// <summary>
        /// AMEDER.
        /// </summary>
        public const string AMEDER = "AMEDER";

        /// <summary>
        /// AMEDDL.
        /// </summary>
        public const string AMEDDL = "AMEDDL";

        /// <summary>
        /// AMEDSP.
        /// </summary>
        public const string AMEDSP = "AMEDSP";

        /// <summary>
        /// AMEDBT.
        /// </summary>
        public const string AMEDBT = "AMEDBT";

        /// <summary>
        /// AMPARTYTYP.
        /// </summary>
        public const string AMPARTYTYP = "AMPARTYTYP";

        /// <summary>
        /// AMEDTY.
        /// </summary>
        public const string AMEDTY = "AMEDTY";

        /// <summary>
        /// AMEDSQ.
        /// </summary>
        public const string AMEDSQ = "AMEDSQ";

        /// <summary>
        /// AMPARTYNM.
        /// </summary>
        public const string AMPARTYNM = "AMPARTYNM";

        /// <summary>
        /// AMPRNA1.
        /// </summary>
        public const string AMPRNA1 = "AMPRNA1";

        /// <summary>
        /// AMPRNA2.
        /// </summary>
        public const string AMPRNA2 = "AMPRNA2";

        /// <summary>
        /// AMDMDAD1.
        /// </summary>
        public const string AMDMDAD1 = "AMDMDAD1";

        /// <summary>
        /// AMDMDAD2.
        /// </summary>
        public const string AMDMDAD2 = "AMDMDAD2";

        /// <summary>
        /// AMCTY1.
        /// </summary>
        public const string AMCTY1 = "AMCTY1";

        /// <summary>
        /// AMSTPROV.
        /// </summary>
        public const string AMSTPROV = "AMSTPROV";

        /// <summary>
        /// AMZIPCD.
        /// </summary>
        public const string AMZIPCD = "AMZIPCD";

        /// <summary>
        /// AMCTR.
        /// </summary>
        public const string AMCTR = "AMCTR";

        /// <summary>
        /// AMCOUN.
        /// </summary>
        public const string AMCOUN = "AMCOUN";

        /// <summary>
        /// AMIDNUMTYP.
        /// </summary>
        public const string AMIDNUMTYP = "AMIDNUMTYP";

        /// <summary>
        /// AMPARTYID.
        /// </summary>
        public const string AMPARTYID = "AMPARTYID";

        /// <summary>
        /// AMURCD.
        /// </summary>
        public const string AMURCD = "AMURCD";

        /// <summary>
        /// AMURDT.
        /// </summary>
        public const string AMURDT = "AMURDT";

        /// <summary>
        /// AMURAT.
        /// </summary>
        public const string AMURAT = "AMURAT";

        /// <summary>
        /// AMURAB.
        /// </summary>
        public const string AMURAB = "AMURAB";

        /// <summary>
        /// AMURRF.
        /// </summary>
        public const string AMURRF = "AMURRF";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMTDAY.
        /// </summary>
        public const string AMTDAY = "AMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470374";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMEDOC", "AMEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AMEDCT", "AMEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AMEKCO", "AMEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AMEDLN", "AMEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AMLINS", "AMLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AMSTPC", "AMSTPC", JdeDataType.String, 2, true, true),
        new JdeField("AMANTY", "AMANTY", JdeDataType.String, 2, true, true),
        new JdeField("AMEDST", "AMEDST", JdeDataType.String, 12),
        new JdeField("AMEDFT", "AMEDFT", JdeDataType.String, 20),
        new JdeField("AMEDDT", "AMEDDT", JdeDataType.Numeric),
        new JdeField("AMEDER", "AMEDER", JdeDataType.String, 2),
        new JdeField("AMEDDL", "AMEDDL", JdeDataType.Numeric),
        new JdeField("AMEDSP", "AMEDSP", JdeDataType.String, 2),
        new JdeField("AMEDBT", "AMEDBT", JdeDataType.String, 30),
        new JdeField("AMPARTYTYP", "AMPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("AMEDTY", "AMEDTY", JdeDataType.String, 2),
        new JdeField("AMEDSQ", "AMEDSQ", JdeDataType.Numeric),
        new JdeField("AMPARTYNM", "AMPARTYNM", JdeDataType.String, 70),
        new JdeField("AMPRNA1", "AMPRNA1", JdeDataType.String, 70),
        new JdeField("AMPRNA2", "AMPRNA2", JdeDataType.String, 70),
        new JdeField("AMDMDAD1", "AMDMDAD1", JdeDataType.String, 70),
        new JdeField("AMDMDAD2", "AMDMDAD2", JdeDataType.String, 70),
        new JdeField("AMCTY1", "AMCTY1", JdeDataType.String, 50),
        new JdeField("AMSTPROV", "AMSTPROV", JdeDataType.String, 70),
        new JdeField("AMZIPCD", "AMZIPCD", JdeDataType.String, 24),
        new JdeField("AMCTR", "AMCTR", JdeDataType.String, 6),
        new JdeField("AMCOUN", "AMCOUN", JdeDataType.String, 50),
        new JdeField("AMIDNUMTYP", "AMIDNUMTYP", JdeDataType.String, 4),
        new JdeField("AMPARTYID", "AMPARTYID", JdeDataType.String, 70),
        new JdeField("AMURCD", "AMURCD", JdeDataType.String, 4),
        new JdeField("AMURDT", "AMURDT", JdeDataType.Numeric),
        new JdeField("AMURAT", "AMURAT", JdeDataType.Numeric),
        new JdeField("AMURAB", "AMURAB", JdeDataType.Numeric),
        new JdeField("AMURRF", "AMURRF", JdeDataType.String, 30),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMTDAY", "AMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470374_0", "Primary Key on AMEDOC, AMEDCT, AMEKCO, AMEDLN, AMLINS, AMSTPC, AMANTY, AMPARTYTYP", new[] { "AMEDOC", "AMEDCT", "AMEKCO", "AMEDLN", "AMLINS", "AMSTPC", "AMANTY", "AMPARTYTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
