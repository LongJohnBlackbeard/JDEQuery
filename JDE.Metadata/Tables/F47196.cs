using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47196 - .
/// </summary>
public class F47196 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAEDTY.
        /// </summary>
        public const string AAEDTY = "AAEDTY";

        /// <summary>
        /// AAEDSQ.
        /// </summary>
        public const string AAEDSQ = "AAEDSQ";

        /// <summary>
        /// AAEKCO.
        /// </summary>
        public const string AAEKCO = "AAEKCO";

        /// <summary>
        /// AAEDOC.
        /// </summary>
        public const string AAEDOC = "AAEDOC";

        /// <summary>
        /// AAEDCT.
        /// </summary>
        public const string AAEDCT = "AAEDCT";

        /// <summary>
        /// AAEDLN.
        /// </summary>
        public const string AAEDLN = "AAEDLN";

        /// <summary>
        /// AAEDST.
        /// </summary>
        public const string AAEDST = "AAEDST";

        /// <summary>
        /// AAEDFT.
        /// </summary>
        public const string AAEDFT = "AAEDFT";

        /// <summary>
        /// AAEDDT.
        /// </summary>
        public const string AAEDDT = "AAEDDT";

        /// <summary>
        /// AAEDER.
        /// </summary>
        public const string AAEDER = "AAEDER";

        /// <summary>
        /// AAEDDL.
        /// </summary>
        public const string AAEDDL = "AAEDDL";

        /// <summary>
        /// AAEDSP.
        /// </summary>
        public const string AAEDSP = "AAEDSP";

        /// <summary>
        /// AAEDBT.
        /// </summary>
        public const string AAEDBT = "AAEDBT";

        /// <summary>
        /// AAPARTYTYP.
        /// </summary>
        public const string AAPARTYTYP = "AAPARTYTYP";

        /// <summary>
        /// AAPARTYID.
        /// </summary>
        public const string AAPARTYID = "AAPARTYID";

        /// <summary>
        /// AAPARTYNM.
        /// </summary>
        public const string AAPARTYNM = "AAPARTYNM";

        /// <summary>
        /// AAIDNUMTYP.
        /// </summary>
        public const string AAIDNUMTYP = "AAIDNUMTYP";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AATDAY.
        /// </summary>
        public const string AATDAY = "AATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47196";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAEDTY", "AAEDTY", JdeDataType.String, 2),
        new JdeField("AAEDSQ", "AAEDSQ", JdeDataType.Numeric),
        new JdeField("AAEKCO", "AAEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AAEDOC", "AAEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AAEDCT", "AAEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AAEDLN", "AAEDLN", JdeDataType.Numeric),
        new JdeField("AAEDST", "AAEDST", JdeDataType.String, 12),
        new JdeField("AAEDFT", "AAEDFT", JdeDataType.String, 20),
        new JdeField("AAEDDT", "AAEDDT", JdeDataType.Numeric),
        new JdeField("AAEDER", "AAEDER", JdeDataType.String, 2),
        new JdeField("AAEDDL", "AAEDDL", JdeDataType.Numeric),
        new JdeField("AAEDSP", "AAEDSP", JdeDataType.String, 2),
        new JdeField("AAEDBT", "AAEDBT", JdeDataType.String, 30),
        new JdeField("AAPARTYTYP", "AAPARTYTYP", JdeDataType.String, 6, true, true),
        new JdeField("AAPARTYID", "AAPARTYID", JdeDataType.String, 70),
        new JdeField("AAPARTYNM", "AAPARTYNM", JdeDataType.String, 70),
        new JdeField("AAIDNUMTYP", "AAIDNUMTYP", JdeDataType.String, 4),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AATDAY", "AATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47196_0", "Primary Key on AAEKCO, AAEDOC, AAEDCT, AAPARTYTYP", new[] { "AAEKCO", "AAEDOC", "AAEDCT", "AAPARTYTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
