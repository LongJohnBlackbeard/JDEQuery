using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1757 - .
/// </summary>
public class F1757 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// ZARCK7.
        /// </summary>
        public const string ZARCK7 = "ZARCK7";

        /// <summary>
        /// ZAPRIOR.
        /// </summary>
        public const string ZAPRIOR = "ZAPRIOR";

        /// <summary>
        /// ZAISSUE.
        /// </summary>
        public const string ZAISSUE = "ZAISSUE";

        /// <summary>
        /// ZAANC.
        /// </summary>
        public const string ZAANC = "ZAANC";

        /// <summary>
        /// ZACLST.
        /// </summary>
        public const string ZACLST = "ZACLST";

        /// <summary>
        /// ZATASKCALL.
        /// </summary>
        public const string ZATASKCALL = "ZATASKCALL";

        /// <summary>
        /// ZADL01.
        /// </summary>
        public const string ZADL01 = "ZADL01";

        /// <summary>
        /// ZAALPH.
        /// </summary>
        public const string ZAALPH = "ZAALPH";

        /// <summary>
        /// ZACALLQ.
        /// </summary>
        public const string ZACALLQ = "ZACALLQ";

        /// <summary>
        /// ZAAN8.
        /// </summary>
        public const string ZAAN8 = "ZAAN8";

        /// <summary>
        /// ZADEF.
        /// </summary>
        public const string ZADEF = "ZADEF";

        /// <summary>
        /// ZAEFTB.
        /// </summary>
        public const string ZAEFTB = "ZAEFTB";

        /// <summary>
        /// ZAEND.
        /// </summary>
        public const string ZAEND = "ZAEND";

        /// <summary>
        /// ZAAR1.
        /// </summary>
        public const string ZAAR1 = "ZAAR1";

        /// <summary>
        /// ZACPH.
        /// </summary>
        public const string ZACPH = "ZACPH";

        /// <summary>
        /// ZAREM1.
        /// </summary>
        public const string ZAREM1 = "ZAREM1";

        /// <summary>
        /// ZACFAX1.
        /// </summary>
        public const string ZACFAX1 = "ZACFAX1";

        /// <summary>
        /// ZAPHN1.
        /// </summary>
        public const string ZAPHN1 = "ZAPHN1";

        /// <summary>
        /// ZASERK.
        /// </summary>
        public const string ZASERK = "ZASERK";

        /// <summary>
        /// ZAURAB.
        /// </summary>
        public const string ZAURAB = "ZAURAB";

        /// <summary>
        /// ZAURCD.
        /// </summary>
        public const string ZAURCD = "ZAURCD";

        /// <summary>
        /// ZAURAT.
        /// </summary>
        public const string ZAURAT = "ZAURAT";

        /// <summary>
        /// ZAURDT.
        /// </summary>
        public const string ZAURDT = "ZAURDT";

        /// <summary>
        /// ZAURRF.
        /// </summary>
        public const string ZAURRF = "ZAURRF";

        /// <summary>
        /// ZAUSER.
        /// </summary>
        public const string ZAUSER = "ZAUSER";

        /// <summary>
        /// ZAUPMJ.
        /// </summary>
        public const string ZAUPMJ = "ZAUPMJ";

        /// <summary>
        /// ZAUPMT.
        /// </summary>
        public const string ZAUPMT = "ZAUPMT";

        /// <summary>
        /// ZAJOBN.
        /// </summary>
        public const string ZAJOBN = "ZAJOBN";

        /// <summary>
        /// ZAPID.
        /// </summary>
        public const string ZAPID = "ZAPID";

        /// <summary>
        /// ZACRTU.
        /// </summary>
        public const string ZACRTU = "ZACRTU";
    }

    /// <inheritdoc />
    public override string TableName => "F1757";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZADOCO", "ZADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZADCTO", "ZADCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZAKCOO", "ZAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZARCK7", "ZARCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAPRIOR", "ZAPRIOR", JdeDataType.String, 4),
        new JdeField("ZAISSUE", "ZAISSUE", JdeDataType.String, 160),
        new JdeField("ZAANC", "ZAANC", JdeDataType.Numeric),
        new JdeField("ZACLST", "ZACLST", JdeDataType.String, 6),
        new JdeField("ZATASKCALL", "ZATASKCALL", JdeDataType.String, 6),
        new JdeField("ZADL01", "ZADL01", JdeDataType.String, 60),
        new JdeField("ZAALPH", "ZAALPH", JdeDataType.String, 80),
        new JdeField("ZACALLQ", "ZACALLQ", JdeDataType.Numeric),
        new JdeField("ZAAN8", "ZAAN8", JdeDataType.Numeric),
        new JdeField("ZADEF", "ZADEF", JdeDataType.Numeric),
        new JdeField("ZAEFTB", "ZAEFTB", JdeDataType.Numeric),
        new JdeField("ZAEND", "ZAEND", JdeDataType.Numeric),
        new JdeField("ZAAR1", "ZAAR1", JdeDataType.String, 12),
        new JdeField("ZACPH", "ZACPH", JdeDataType.String, 40),
        new JdeField("ZAREM1", "ZAREM1", JdeDataType.String, 80),
        new JdeField("ZACFAX1", "ZACFAX1", JdeDataType.String, 40),
        new JdeField("ZAPHN1", "ZAPHN1", JdeDataType.String, 40),
        new JdeField("ZASERK", "ZASERK", JdeDataType.Numeric),
        new JdeField("ZAURAB", "ZAURAB", JdeDataType.Numeric),
        new JdeField("ZAURCD", "ZAURCD", JdeDataType.String, 4),
        new JdeField("ZAURAT", "ZAURAT", JdeDataType.Numeric),
        new JdeField("ZAURDT", "ZAURDT", JdeDataType.Numeric),
        new JdeField("ZAURRF", "ZAURRF", JdeDataType.String, 30),
        new JdeField("ZAUSER", "ZAUSER", JdeDataType.String, 20),
        new JdeField("ZAUPMJ", "ZAUPMJ", JdeDataType.Numeric),
        new JdeField("ZAUPMT", "ZAUPMT", JdeDataType.Numeric),
        new JdeField("ZAJOBN", "ZAJOBN", JdeDataType.String, 20),
        new JdeField("ZAPID", "ZAPID", JdeDataType.String, 20),
        new JdeField("ZACRTU", "ZACRTU", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1757_0", "Primary Key on ZADOCO, ZADCTO, ZAKCOO, ZARCK7", new[] { "ZADOCO", "ZADCTO", "ZAKCOO", "ZARCK7" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1757_2", "Index on ZASERK", new[] { "ZASERK" })
    };
}
