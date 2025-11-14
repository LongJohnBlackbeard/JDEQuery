using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q211 - .
/// </summary>
public class F43Q211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDEVNU.
        /// </summary>
        public const string EDEVNU = "EDEVNU";

        /// <summary>
        /// EDDCTO.
        /// </summary>
        public const string EDDCTO = "EDDCTO";

        /// <summary>
        /// EDKCOO.
        /// </summary>
        public const string EDKCOO = "EDKCOO";

        /// <summary>
        /// EDEVLN.
        /// </summary>
        public const string EDEVLN = "EDEVLN";

        /// <summary>
        /// EDBIDQN.
        /// </summary>
        public const string EDBIDQN = "EDBIDQN";

        /// <summary>
        /// EDLLNB.
        /// </summary>
        public const string EDLLNB = "EDLLNB";

        /// <summary>
        /// EDLTIT.
        /// </summary>
        public const string EDLTIT = "EDLTIT";

        /// <summary>
        /// EDLSTSCR.
        /// </summary>
        public const string EDLSTSCR = "EDLSTSCR";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDTORG.
        /// </summary>
        public const string EDTORG = "EDTORG";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDTDAY.
        /// </summary>
        public const string EDTDAY = "EDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEVNU", "EDEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDCTO", "EDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EDKCOO", "EDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EDEVLN", "EDEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDBIDQN", "EDBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDLLNB", "EDLLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("EDLTIT", "EDLTIT", JdeDataType.String, 110),
        new JdeField("EDLSTSCR", "EDLSTSCR", JdeDataType.Numeric),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDTORG", "EDTORG", JdeDataType.String, 20),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDTDAY", "EDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q211_0", "Primary Key on EDEVNU, EDDCTO, EDKCOO, EDEVLN, EDBIDQN, EDLLNB", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDEVLN", "EDBIDQN", "EDLLNB" }, isUnique: true, isPrimaryKey: true)
    };
}
