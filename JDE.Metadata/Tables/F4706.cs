using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4706 - .
/// </summary>
public class F4706 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZAEDTY.
        /// </summary>
        public const string ZAEDTY = "ZAEDTY";

        /// <summary>
        /// ZAEDSQ.
        /// </summary>
        public const string ZAEDSQ = "ZAEDSQ";

        /// <summary>
        /// ZAEKCO.
        /// </summary>
        public const string ZAEKCO = "ZAEKCO";

        /// <summary>
        /// ZAEDOC.
        /// </summary>
        public const string ZAEDOC = "ZAEDOC";

        /// <summary>
        /// ZAEDCT.
        /// </summary>
        public const string ZAEDCT = "ZAEDCT";

        /// <summary>
        /// ZAEDLN.
        /// </summary>
        public const string ZAEDLN = "ZAEDLN";

        /// <summary>
        /// ZAEDSP.
        /// </summary>
        public const string ZAEDSP = "ZAEDSP";

        /// <summary>
        /// ZAEDBT.
        /// </summary>
        public const string ZAEDBT = "ZAEDBT";

        /// <summary>
        /// ZAFILE.
        /// </summary>
        public const string ZAFILE = "ZAFILE";

        /// <summary>
        /// ZADOCO.
        /// </summary>
        public const string ZADOCO = "ZADOCO";

        /// <summary>
        /// ZADCTO.
        /// </summary>
        public const string ZADCTO = "ZADCTO";

        /// <summary>
        /// ZAKCOO.
        /// </summary>
        public const string ZAKCOO = "ZAKCOO";

        /// <summary>
        /// ZAANTY.
        /// </summary>
        public const string ZAANTY = "ZAANTY";

        /// <summary>
        /// ZAAN8.
        /// </summary>
        public const string ZAAN8 = "ZAAN8";

        /// <summary>
        /// ZAMLNM.
        /// </summary>
        public const string ZAMLNM = "ZAMLNM";

        /// <summary>
        /// ZAADD1.
        /// </summary>
        public const string ZAADD1 = "ZAADD1";

        /// <summary>
        /// ZAADD2.
        /// </summary>
        public const string ZAADD2 = "ZAADD2";

        /// <summary>
        /// ZAADD3.
        /// </summary>
        public const string ZAADD3 = "ZAADD3";

        /// <summary>
        /// ZAADD4.
        /// </summary>
        public const string ZAADD4 = "ZAADD4";

        /// <summary>
        /// ZAADDZ.
        /// </summary>
        public const string ZAADDZ = "ZAADDZ";

        /// <summary>
        /// ZACTY1.
        /// </summary>
        public const string ZACTY1 = "ZACTY1";

        /// <summary>
        /// ZACOUN.
        /// </summary>
        public const string ZACOUN = "ZACOUN";

        /// <summary>
        /// ZAADDS.
        /// </summary>
        public const string ZAADDS = "ZAADDS";

        /// <summary>
        /// ZACRTE.
        /// </summary>
        public const string ZACRTE = "ZACRTE";

        /// <summary>
        /// ZABKML.
        /// </summary>
        public const string ZABKML = "ZABKML";

        /// <summary>
        /// ZACTR.
        /// </summary>
        public const string ZACTR = "ZACTR";

        /// <summary>
        /// ZATORG.
        /// </summary>
        public const string ZATORG = "ZATORG";

        /// <summary>
        /// ZAUSER.
        /// </summary>
        public const string ZAUSER = "ZAUSER";

        /// <summary>
        /// ZAPID.
        /// </summary>
        public const string ZAPID = "ZAPID";

        /// <summary>
        /// ZAJOBN.
        /// </summary>
        public const string ZAJOBN = "ZAJOBN";

        /// <summary>
        /// ZAUPMJ.
        /// </summary>
        public const string ZAUPMJ = "ZAUPMJ";

        /// <summary>
        /// ZATDAY.
        /// </summary>
        public const string ZATDAY = "ZATDAY";

        /// <summary>
        /// ZALNID.
        /// </summary>
        public const string ZALNID = "ZALNID";

        /// <summary>
        /// ZAGAN8.
        /// </summary>
        public const string ZAGAN8 = "ZAGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F4706";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZAEDTY", "ZAEDTY", JdeDataType.String, 2),
        new JdeField("ZAEDSQ", "ZAEDSQ", JdeDataType.Numeric),
        new JdeField("ZAEKCO", "ZAEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZAEDOC", "ZAEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAEDCT", "ZAEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ZAEDLN", "ZAEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAEDSP", "ZAEDSP", JdeDataType.String, 2),
        new JdeField("ZAEDBT", "ZAEDBT", JdeDataType.String, 30),
        new JdeField("ZAFILE", "ZAFILE", JdeDataType.String, 20, true, true),
        new JdeField("ZADOCO", "ZADOCO", JdeDataType.Numeric),
        new JdeField("ZADCTO", "ZADCTO", JdeDataType.String, 4),
        new JdeField("ZAKCOO", "ZAKCOO", JdeDataType.String, 10),
        new JdeField("ZAANTY", "ZAANTY", JdeDataType.String, 2, true, true),
        new JdeField("ZAAN8", "ZAAN8", JdeDataType.Numeric),
        new JdeField("ZAMLNM", "ZAMLNM", JdeDataType.String, 80),
        new JdeField("ZAADD1", "ZAADD1", JdeDataType.String, 80),
        new JdeField("ZAADD2", "ZAADD2", JdeDataType.String, 80),
        new JdeField("ZAADD3", "ZAADD3", JdeDataType.String, 80),
        new JdeField("ZAADD4", "ZAADD4", JdeDataType.String, 80),
        new JdeField("ZAADDZ", "ZAADDZ", JdeDataType.String, 24),
        new JdeField("ZACTY1", "ZACTY1", JdeDataType.String, 50),
        new JdeField("ZACOUN", "ZACOUN", JdeDataType.String, 50),
        new JdeField("ZAADDS", "ZAADDS", JdeDataType.String, 6),
        new JdeField("ZACRTE", "ZACRTE", JdeDataType.String, 8),
        new JdeField("ZABKML", "ZABKML", JdeDataType.String, 4),
        new JdeField("ZACTR", "ZACTR", JdeDataType.String, 6),
        new JdeField("ZATORG", "ZATORG", JdeDataType.String, 20),
        new JdeField("ZAUSER", "ZAUSER", JdeDataType.String, 20),
        new JdeField("ZAPID", "ZAPID", JdeDataType.String, 20),
        new JdeField("ZAJOBN", "ZAJOBN", JdeDataType.String, 20),
        new JdeField("ZAUPMJ", "ZAUPMJ", JdeDataType.Numeric),
        new JdeField("ZATDAY", "ZATDAY", JdeDataType.Numeric),
        new JdeField("ZALNID", "ZALNID", JdeDataType.Numeric),
        new JdeField("ZAGAN8", "ZAGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4706_0", "Primary Key on ZAFILE, ZAEDOC, ZAEDCT, ZAEKCO, ZAEDLN, ZAANTY", new[] { "ZAFILE", "ZAEDOC", "ZAEDCT", "ZAEKCO", "ZAEDLN", "ZAANTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4706_2", "Index on ZAEDOC, ZAEDCT, ZAEKCO, ZAANTY", new[] { "ZAEDOC", "ZAEDCT", "ZAEKCO", "ZAANTY" }),
        new JdeIndex("F4706_3", "Index on ZAEKCO, ZAEDCT, ZAEDBT", new[] { "ZAEKCO", "ZAEDCT", "ZAEDBT" }),
        new JdeIndex("F4706_4", "Index on ZAEKCO, ZAEDCT, ZAEDOC, ZAEDLN", new[] { "ZAEKCO", "ZAEDCT", "ZAEDOC", "ZAEDLN" })
    };
}
