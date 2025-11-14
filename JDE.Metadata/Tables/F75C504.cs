using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C504 - .
/// </summary>
public class F75C504 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCC75PCID.
        /// </summary>
        public const string PCC75PCID = "PCC75PCID";

        /// <summary>
        /// PCC75PCNAM.
        /// </summary>
        public const string PCC75PCNAM = "PCC75PCNAM";

        /// <summary>
        /// PCCO.
        /// </summary>
        public const string PCCO = "PCCO";

        /// <summary>
        /// PCC75CUR.
        /// </summary>
        public const string PCC75CUR = "PCC75CUR";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCFUTMATH1.
        /// </summary>
        public const string PCFUTMATH1 = "PCFUTMATH1";

        /// <summary>
        /// PCFUTSTR1.
        /// </summary>
        public const string PCFUTSTR1 = "PCFUTSTR1";

        /// <summary>
        /// PCFUTSTR2.
        /// </summary>
        public const string PCFUTSTR2 = "PCFUTSTR2";

        /// <summary>
        /// PCFUTDATE1.
        /// </summary>
        public const string PCFUTDATE1 = "PCFUTDATE1";

        /// <summary>
        /// PCFUTUO1.
        /// </summary>
        public const string PCFUTUO1 = "PCFUTUO1";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75C504";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCC75PCID", "PCC75PCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCC75PCNAM", "PCC75PCNAM", JdeDataType.String, 120),
        new JdeField("PCCO", "PCCO", JdeDataType.String, 10),
        new JdeField("PCC75CUR", "PCC75CUR", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCFUTMATH1", "PCFUTMATH1", JdeDataType.Numeric),
        new JdeField("PCFUTSTR1", "PCFUTSTR1", JdeDataType.String, 100),
        new JdeField("PCFUTSTR2", "PCFUTSTR2", JdeDataType.String, 100),
        new JdeField("PCFUTDATE1", "PCFUTDATE1", JdeDataType.Numeric),
        new JdeField("PCFUTUO1", "PCFUTUO1", JdeDataType.String, 2),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C504_0", "Primary Key on PCC75PCID", new[] { "PCC75PCID" }, isUnique: true, isPrimaryKey: true)
    };
}
