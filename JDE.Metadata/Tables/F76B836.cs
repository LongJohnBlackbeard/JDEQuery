using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B836 - .
/// </summary>
public class F76B836 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHJOBS.
        /// </summary>
        public const string JHJOBS = "JHJOBS";

        /// <summary>
        /// JHB76WRTY.
        /// </summary>
        public const string JHB76WRTY = "JHB76WRTY";

        /// <summary>
        /// JHB76RNP.
        /// </summary>
        public const string JHB76RNP = "JHB76RNP";

        /// <summary>
        /// JHB76PDL.
        /// </summary>
        public const string JHB76PDL = "JHB76PDL";

        /// <summary>
        /// JHB76FPBI.
        /// </summary>
        public const string JHB76FPBI = "JHB76FPBI";

        /// <summary>
        /// JHB76FTM.
        /// </summary>
        public const string JHB76FTM = "JHB76FTM";

        /// <summary>
        /// JHB76FFQP.
        /// </summary>
        public const string JHB76FFQP = "JHB76FFQP";

        /// <summary>
        /// JHB76FSQP.
        /// </summary>
        public const string JHB76FSQP = "JHB76FSQP";

        /// <summary>
        /// JHB76FTQP.
        /// </summary>
        public const string JHB76FTQP = "JHB76FTQP";

        /// <summary>
        /// JHB76FOQP.
        /// </summary>
        public const string JHB76FOQP = "JHB76FOQP";

        /// <summary>
        /// JHB76FFQM.
        /// </summary>
        public const string JHB76FFQM = "JHB76FFQM";

        /// <summary>
        /// JHB76FSQM.
        /// </summary>
        public const string JHB76FSQM = "JHB76FSQM";

        /// <summary>
        /// JHB76FTQM.
        /// </summary>
        public const string JHB76FTQM = "JHB76FTQM";

        /// <summary>
        /// JHB76FOQM.
        /// </summary>
        public const string JHB76FOQM = "JHB76FOQM";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHJOBN.
        /// </summary>
        public const string JHJOBN = "JHJOBN";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHUPMT.
        /// </summary>
        public const string JHUPMT = "JHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B836";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHJOBS", "JHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JHB76WRTY", "JHB76WRTY", JdeDataType.Numeric),
        new JdeField("JHB76RNP", "JHB76RNP", JdeDataType.String, 82),
        new JdeField("JHB76PDL", "JHB76PDL", JdeDataType.String, 2),
        new JdeField("JHB76FPBI", "JHB76FPBI", JdeDataType.String, 20),
        new JdeField("JHB76FTM", "JHB76FTM", JdeDataType.String, 20),
        new JdeField("JHB76FFQP", "JHB76FFQP", JdeDataType.String, 2),
        new JdeField("JHB76FSQP", "JHB76FSQP", JdeDataType.String, 2),
        new JdeField("JHB76FTQP", "JHB76FTQP", JdeDataType.String, 2),
        new JdeField("JHB76FOQP", "JHB76FOQP", JdeDataType.String, 2),
        new JdeField("JHB76FFQM", "JHB76FFQM", JdeDataType.String, 20),
        new JdeField("JHB76FSQM", "JHB76FSQM", JdeDataType.String, 20),
        new JdeField("JHB76FTQM", "JHB76FTQM", JdeDataType.String, 20),
        new JdeField("JHB76FOQM", "JHB76FOQM", JdeDataType.String, 20),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHJOBN", "JHJOBN", JdeDataType.String, 20),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHUPMT", "JHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B836_0", "Primary Key on JHJOBS", new[] { "JHJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
