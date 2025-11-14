using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471722 - .
/// </summary>
public class F471722 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAEDTY.
        /// </summary>
        public const string EAEDTY = "EAEDTY";

        /// <summary>
        /// EAEDSQ.
        /// </summary>
        public const string EAEDSQ = "EAEDSQ";

        /// <summary>
        /// EAEKCO.
        /// </summary>
        public const string EAEKCO = "EAEKCO";

        /// <summary>
        /// EAEDOC.
        /// </summary>
        public const string EAEDOC = "EAEDOC";

        /// <summary>
        /// EAEDCT.
        /// </summary>
        public const string EAEDCT = "EAEDCT";

        /// <summary>
        /// EAEDLN.
        /// </summary>
        public const string EAEDLN = "EAEDLN";

        /// <summary>
        /// EAEDST.
        /// </summary>
        public const string EAEDST = "EAEDST";

        /// <summary>
        /// EAEDFT.
        /// </summary>
        public const string EAEDFT = "EAEDFT";

        /// <summary>
        /// EAEDDT.
        /// </summary>
        public const string EAEDDT = "EAEDDT";

        /// <summary>
        /// EAEDER.
        /// </summary>
        public const string EAEDER = "EAEDER";

        /// <summary>
        /// EAEDDL.
        /// </summary>
        public const string EAEDDL = "EAEDDL";

        /// <summary>
        /// EAEDSP.
        /// </summary>
        public const string EAEDSP = "EAEDSP";

        /// <summary>
        /// EAEDBT.
        /// </summary>
        public const string EAEDBT = "EAEDBT";

        /// <summary>
        /// EAEDSLN.
        /// </summary>
        public const string EAEDSLN = "EAEDSLN";

        /// <summary>
        /// EAPARTYTYP.
        /// </summary>
        public const string EAPARTYTYP = "EAPARTYTYP";

        /// <summary>
        /// EAPARTYNM.
        /// </summary>
        public const string EAPARTYNM = "EAPARTYNM";

        /// <summary>
        /// EAPRNA1.
        /// </summary>
        public const string EAPRNA1 = "EAPRNA1";

        /// <summary>
        /// EAPRNA2.
        /// </summary>
        public const string EAPRNA2 = "EAPRNA2";

        /// <summary>
        /// EADMDAD1.
        /// </summary>
        public const string EADMDAD1 = "EADMDAD1";

        /// <summary>
        /// EADMDAD2.
        /// </summary>
        public const string EADMDAD2 = "EADMDAD2";

        /// <summary>
        /// EACITY1.
        /// </summary>
        public const string EACITY1 = "EACITY1";

        /// <summary>
        /// EASTPROV.
        /// </summary>
        public const string EASTPROV = "EASTPROV";

        /// <summary>
        /// EAZIPCD.
        /// </summary>
        public const string EAZIPCD = "EAZIPCD";

        /// <summary>
        /// EACTR.
        /// </summary>
        public const string EACTR = "EACTR";

        /// <summary>
        /// EACOUN.
        /// </summary>
        public const string EACOUN = "EACOUN";

        /// <summary>
        /// EAIDNUMTYP.
        /// </summary>
        public const string EAIDNUMTYP = "EAIDNUMTYP";

        /// <summary>
        /// EAPARTYID.
        /// </summary>
        public const string EAPARTYID = "EAPARTYID";

        /// <summary>
        /// EAURCD.
        /// </summary>
        public const string EAURCD = "EAURCD";

        /// <summary>
        /// EAURDT.
        /// </summary>
        public const string EAURDT = "EAURDT";

        /// <summary>
        /// EAURAT.
        /// </summary>
        public const string EAURAT = "EAURAT";

        /// <summary>
        /// EAURAB.
        /// </summary>
        public const string EAURAB = "EAURAB";

        /// <summary>
        /// EAURRF.
        /// </summary>
        public const string EAURRF = "EAURRF";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EATDAY.
        /// </summary>
        public const string EATDAY = "EATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F471722";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAEDTY", "EAEDTY", JdeDataType.String, 2),
        new JdeField("EAEDSQ", "EAEDSQ", JdeDataType.Numeric),
        new JdeField("EAEKCO", "EAEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EAEDOC", "EAEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEDCT", "EAEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EAEDLN", "EAEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEDST", "EAEDST", JdeDataType.String, 12),
        new JdeField("EAEDFT", "EAEDFT", JdeDataType.String, 20),
        new JdeField("EAEDDT", "EAEDDT", JdeDataType.Numeric),
        new JdeField("EAEDER", "EAEDER", JdeDataType.String, 2),
        new JdeField("EAEDDL", "EAEDDL", JdeDataType.Numeric),
        new JdeField("EAEDSP", "EAEDSP", JdeDataType.String, 2),
        new JdeField("EAEDBT", "EAEDBT", JdeDataType.String, 30),
        new JdeField("EAEDSLN", "EAEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EAPARTYTYP", "EAPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("EAPARTYNM", "EAPARTYNM", JdeDataType.String, 70),
        new JdeField("EAPRNA1", "EAPRNA1", JdeDataType.String, 70),
        new JdeField("EAPRNA2", "EAPRNA2", JdeDataType.String, 70),
        new JdeField("EADMDAD1", "EADMDAD1", JdeDataType.String, 70),
        new JdeField("EADMDAD2", "EADMDAD2", JdeDataType.String, 70),
        new JdeField("EACITY1", "EACITY1", JdeDataType.String, 40),
        new JdeField("EASTPROV", "EASTPROV", JdeDataType.String, 70),
        new JdeField("EAZIPCD", "EAZIPCD", JdeDataType.String, 24),
        new JdeField("EACTR", "EACTR", JdeDataType.String, 6),
        new JdeField("EACOUN", "EACOUN", JdeDataType.String, 50),
        new JdeField("EAIDNUMTYP", "EAIDNUMTYP", JdeDataType.String, 4),
        new JdeField("EAPARTYID", "EAPARTYID", JdeDataType.String, 70),
        new JdeField("EAURCD", "EAURCD", JdeDataType.String, 4),
        new JdeField("EAURDT", "EAURDT", JdeDataType.Numeric),
        new JdeField("EAURAT", "EAURAT", JdeDataType.Numeric),
        new JdeField("EAURAB", "EAURAB", JdeDataType.Numeric),
        new JdeField("EAURRF", "EAURRF", JdeDataType.String, 30),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EATDAY", "EATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471722_0", "Primary Key on EAEDOC, EAEDCT, EAEKCO, EAEDLN, EAEDSLN, EAPARTYTYP", new[] { "EAEDOC", "EAEDCT", "EAEKCO", "EAEDLN", "EAEDSLN", "EAPARTYTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
