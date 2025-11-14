using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C910 - .
/// </summary>
public class F75C910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFCO.
        /// </summary>
        public const string CFCO = "CFCO";

        /// <summary>
        /// CFFYR.
        /// </summary>
        public const string CFFYR = "CFFYR";

        /// <summary>
        /// CFPN.
        /// </summary>
        public const string CFPN = "CFPN";

        /// <summary>
        /// CFC75RID.
        /// </summary>
        public const string CFC75RID = "CFC75RID";

        /// <summary>
        /// CFC75SEQN.
        /// </summary>
        public const string CFC75SEQN = "CFC75SEQN";

        /// <summary>
        /// CFAN01.
        /// </summary>
        public const string CFAN01 = "CFAN01";

        /// <summary>
        /// CFAA.
        /// </summary>
        public const string CFAA = "CFAA";

        /// <summary>
        /// CFCRCD.
        /// </summary>
        public const string CFCRCD = "CFCRCD";

        /// <summary>
        /// CFFUTMATH1.
        /// </summary>
        public const string CFFUTMATH1 = "CFFUTMATH1";

        /// <summary>
        /// CFFUTDATE1.
        /// </summary>
        public const string CFFUTDATE1 = "CFFUTDATE1";

        /// <summary>
        /// CFFUTSTR1.
        /// </summary>
        public const string CFFUTSTR1 = "CFFUTSTR1";

        /// <summary>
        /// CFFUTUO1.
        /// </summary>
        public const string CFFUTUO1 = "CFFUTUO1";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFCO", "CFCO", JdeDataType.String, 10, true, true),
        new JdeField("CFFYR", "CFFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("CFPN", "CFPN", JdeDataType.Numeric, null, true, true),
        new JdeField("CFC75RID", "CFC75RID", JdeDataType.String, 6, true, true),
        new JdeField("CFC75SEQN", "CFC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("CFAN01", "CFAN01", JdeDataType.Numeric),
        new JdeField("CFAA", "CFAA", JdeDataType.Numeric),
        new JdeField("CFCRCD", "CFCRCD", JdeDataType.String, 6),
        new JdeField("CFFUTMATH1", "CFFUTMATH1", JdeDataType.Numeric),
        new JdeField("CFFUTDATE1", "CFFUTDATE1", JdeDataType.Numeric),
        new JdeField("CFFUTSTR1", "CFFUTSTR1", JdeDataType.String, 100),
        new JdeField("CFFUTUO1", "CFFUTUO1", JdeDataType.String, 2),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C910_0", "Primary Key on CFC75RID, CFCO, CFFYR, CFPN, CFC75SEQN", new[] { "CFC75RID", "CFCO", "CFFYR", "CFPN", "CFC75SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
