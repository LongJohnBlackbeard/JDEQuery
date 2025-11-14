using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B01TE - .
/// </summary>
public class F76B01TE : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHBNNF.
        /// </summary>
        public const string FHBNNF = "FHBNNF";

        /// <summary>
        /// FHBSER.
        /// </summary>
        public const string FHBSER = "FHBSER";

        /// <summary>
        /// FHN001.
        /// </summary>
        public const string FHN001 = "FHN001";

        /// <summary>
        /// FHDCT.
        /// </summary>
        public const string FHDCT = "FHDCT";

        /// <summary>
        /// FHB76ELN.
        /// </summary>
        public const string FHB76ELN = "FHB76ELN";

        /// <summary>
        /// FHB76ELND.
        /// </summary>
        public const string FHB76ELND = "FHB76ELND";

        /// <summary>
        /// FHB76ELNT.
        /// </summary>
        public const string FHB76ELNT = "FHB76ELNT";

        /// <summary>
        /// FHB76ERN.
        /// </summary>
        public const string FHB76ERN = "FHB76ERN";

        /// <summary>
        /// FHB76ERND.
        /// </summary>
        public const string FHB76ERND = "FHB76ERND";

        /// <summary>
        /// FHB76ERNT.
        /// </summary>
        public const string FHB76ERNT = "FHB76ERNT";

        /// <summary>
        /// FHB76EAN.
        /// </summary>
        public const string FHB76EAN = "FHB76EAN";

        /// <summary>
        /// FHB76EAND.
        /// </summary>
        public const string FHB76EAND = "FHB76EAND";

        /// <summary>
        /// FHB76EANT.
        /// </summary>
        public const string FHB76EANT = "FHB76EANT";

        /// <summary>
        /// FHB76EST.
        /// </summary>
        public const string FHB76EST = "FHB76EST";

        /// <summary>
        /// FHB76ESTC.
        /// </summary>
        public const string FHB76ESTC = "FHB76ESTC";

        /// <summary>
        /// FHB76ESTD.
        /// </summary>
        public const string FHB76ESTD = "FHB76ESTD";

        /// <summary>
        /// FHB76EREF.
        /// </summary>
        public const string FHB76EREF = "FHB76EREF";

        /// <summary>
        /// FHB76EAA.
        /// </summary>
        public const string FHB76EAA = "FHB76EAA";

        /// <summary>
        /// FHB76ETPR.
        /// </summary>
        public const string FHB76ETPR = "FHB76ETPR";

        /// <summary>
        /// FHURCD.
        /// </summary>
        public const string FHURCD = "FHURCD";

        /// <summary>
        /// FHURDT.
        /// </summary>
        public const string FHURDT = "FHURDT";

        /// <summary>
        /// FHURAT.
        /// </summary>
        public const string FHURAT = "FHURAT";

        /// <summary>
        /// FHURRF.
        /// </summary>
        public const string FHURRF = "FHURRF";

        /// <summary>
        /// FHTORG.
        /// </summary>
        public const string FHTORG = "FHTORG";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHTDAY.
        /// </summary>
        public const string FHTDAY = "FHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B01TE";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHBNNF", "FHBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FHBSER", "FHBSER", JdeDataType.String, 4, true, true),
        new JdeField("FHN001", "FHN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FHDCT", "FHDCT", JdeDataType.String, 4, true, true),
        new JdeField("FHB76ELN", "FHB76ELN", JdeDataType.String, 60),
        new JdeField("FHB76ELND", "FHB76ELND", JdeDataType.Numeric),
        new JdeField("FHB76ELNT", "FHB76ELNT", JdeDataType.Numeric),
        new JdeField("FHB76ERN", "FHB76ERN", JdeDataType.String, 60),
        new JdeField("FHB76ERND", "FHB76ERND", JdeDataType.Numeric),
        new JdeField("FHB76ERNT", "FHB76ERNT", JdeDataType.Numeric),
        new JdeField("FHB76EAN", "FHB76EAN", JdeDataType.String, 60),
        new JdeField("FHB76EAND", "FHB76EAND", JdeDataType.Numeric),
        new JdeField("FHB76EANT", "FHB76EANT", JdeDataType.Numeric),
        new JdeField("FHB76EST", "FHB76EST", JdeDataType.String, 2),
        new JdeField("FHB76ESTC", "FHB76ESTC", JdeDataType.String, 20),
        new JdeField("FHB76ESTD", "FHB76ESTD", JdeDataType.Numeric),
        new JdeField("FHB76EREF", "FHB76EREF", JdeDataType.String, 80),
        new JdeField("FHB76EAA", "FHB76EAA", JdeDataType.String),
        new JdeField("FHB76ETPR", "FHB76ETPR", JdeDataType.String, 20),
        new JdeField("FHURCD", "FHURCD", JdeDataType.String, 4),
        new JdeField("FHURDT", "FHURDT", JdeDataType.Numeric),
        new JdeField("FHURAT", "FHURAT", JdeDataType.Numeric),
        new JdeField("FHURRF", "FHURRF", JdeDataType.String, 30),
        new JdeField("FHTORG", "FHTORG", JdeDataType.String, 20),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHTDAY", "FHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B01TE_0", "Primary Key on FHBNNF, FHBSER, FHN001, FHDCT", new[] { "FHBNNF", "FHBSER", "FHN001", "FHDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B01TE_2", "Index on FHB76ELN", new[] { "FHB76ELN" }),
        new JdeIndex("F76B01TE_3", "Index on FHB76ERN", new[] { "FHB76ERN" })
    };
}
