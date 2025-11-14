using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C911A - .
/// </summary>
public class F75C911A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALKCO.
        /// </summary>
        public const string ALKCO = "ALKCO";

        /// <summary>
        /// ALDCT.
        /// </summary>
        public const string ALDCT = "ALDCT";

        /// <summary>
        /// ALDOC.
        /// </summary>
        public const string ALDOC = "ALDOC";

        /// <summary>
        /// ALDGJ.
        /// </summary>
        public const string ALDGJ = "ALDGJ";

        /// <summary>
        /// ALLT.
        /// </summary>
        public const string ALLT = "ALLT";

        /// <summary>
        /// ALJELN.
        /// </summary>
        public const string ALJELN = "ALJELN";

        /// <summary>
        /// ALEXTL.
        /// </summary>
        public const string ALEXTL = "ALEXTL";

        /// <summary>
        /// ALFLAG.
        /// </summary>
        public const string ALFLAG = "ALFLAG";

        /// <summary>
        /// ALFUTMATH1.
        /// </summary>
        public const string ALFUTMATH1 = "ALFUTMATH1";

        /// <summary>
        /// ALFUTSTR1.
        /// </summary>
        public const string ALFUTSTR1 = "ALFUTSTR1";

        /// <summary>
        /// ALFUTSTR2.
        /// </summary>
        public const string ALFUTSTR2 = "ALFUTSTR2";

        /// <summary>
        /// ALFUTDATE1.
        /// </summary>
        public const string ALFUTDATE1 = "ALFUTDATE1";

        /// <summary>
        /// ALFUTUO1.
        /// </summary>
        public const string ALFUTUO1 = "ALFUTUO1";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALJOBN.
        /// </summary>
        public const string ALJOBN = "ALJOBN";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALUPMT.
        /// </summary>
        public const string ALUPMT = "ALUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C911A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALKCO", "ALKCO", JdeDataType.String, 10, true, true),
        new JdeField("ALDCT", "ALDCT", JdeDataType.String, 4, true, true),
        new JdeField("ALDOC", "ALDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ALDGJ", "ALDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALLT", "ALLT", JdeDataType.String, 4, true, true),
        new JdeField("ALJELN", "ALJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("ALEXTL", "ALEXTL", JdeDataType.String, 4, true, true),
        new JdeField("ALFLAG", "ALFLAG", JdeDataType.String, 2),
        new JdeField("ALFUTMATH1", "ALFUTMATH1", JdeDataType.Numeric),
        new JdeField("ALFUTSTR1", "ALFUTSTR1", JdeDataType.String, 100),
        new JdeField("ALFUTSTR2", "ALFUTSTR2", JdeDataType.String, 100),
        new JdeField("ALFUTDATE1", "ALFUTDATE1", JdeDataType.Numeric),
        new JdeField("ALFUTUO1", "ALFUTUO1", JdeDataType.String, 2),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALJOBN", "ALJOBN", JdeDataType.String, 20),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALUPMT", "ALUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C911A_0", "Primary Key on ALDCT, ALDOC, ALKCO, ALDGJ, ALJELN, ALLT, ALEXTL", new[] { "ALDCT", "ALDOC", "ALKCO", "ALDGJ", "ALJELN", "ALLT", "ALEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
