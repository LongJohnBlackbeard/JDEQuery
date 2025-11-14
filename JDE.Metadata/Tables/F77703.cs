using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77703 - .
/// </summary>
public class F77703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARAN8.
        /// </summary>
        public const string ARAN8 = "ARAN8";

        /// <summary>
        /// ARHMCO.
        /// </summary>
        public const string ARHMCO = "ARHMCO";

        /// <summary>
        /// ARTAXX.
        /// </summary>
        public const string ARTAXX = "ARTAXX";

        /// <summary>
        /// ARPTAX.
        /// </summary>
        public const string ARPTAX = "ARPTAX";

        /// <summary>
        /// AREKEY.
        /// </summary>
        public const string AREKEY = "AREKEY";

        /// <summary>
        /// ARALPH.
        /// </summary>
        public const string ARALPH = "ARALPH";

        /// <summary>
        /// ARCENTYR.
        /// </summary>
        public const string ARCENTYR = "ARCENTYR";

        /// <summary>
        /// ARHMO.
        /// </summary>
        public const string ARHMO = "ARHMO";

        /// <summary>
        /// ARTARA.
        /// </summary>
        public const string ARTARA = "ARTARA";

        /// <summary>
        /// ARPDBA.
        /// </summary>
        public const string ARPDBA = "ARPDBA";

        /// <summary>
        /// ARCKCN.
        /// </summary>
        public const string ARCKCN = "ARCKCN";

        /// <summary>
        /// ARFILE.
        /// </summary>
        public const string ARFILE = "ARFILE";

        /// <summary>
        /// AREFLN.
        /// </summary>
        public const string AREFLN = "AREFLN";

        /// <summary>
        /// ARMATH01.
        /// </summary>
        public const string ARMATH01 = "ARMATH01";

        /// <summary>
        /// ARMATH02.
        /// </summary>
        public const string ARMATH02 = "ARMATH02";
    }

    /// <inheritdoc />
    public override string TableName => "F77703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARAN8", "ARAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ARHMCO", "ARHMCO", JdeDataType.String, 10, true, true),
        new JdeField("ARTAXX", "ARTAXX", JdeDataType.String, 40, true, true),
        new JdeField("ARPTAX", "ARPTAX", JdeDataType.String, 4, true, true),
        new JdeField("AREKEY", "AREKEY", JdeDataType.String, 8, true, true),
        new JdeField("ARALPH", "ARALPH", JdeDataType.String, 80),
        new JdeField("ARCENTYR", "ARCENTYR", JdeDataType.Numeric),
        new JdeField("ARHMO", "ARHMO", JdeDataType.Numeric),
        new JdeField("ARTARA", "ARTARA", JdeDataType.String, 20, true, true),
        new JdeField("ARPDBA", "ARPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ARCKCN", "ARCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("ARFILE", "ARFILE", JdeDataType.String, 20),
        new JdeField("AREFLN", "AREFLN", JdeDataType.String, 30),
        new JdeField("ARMATH01", "ARMATH01", JdeDataType.Numeric),
        new JdeField("ARMATH02", "ARMATH02", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77703_0", "Primary Key on AREKEY, ARHMCO, ARAN8, ARPTAX, ARTAXX, ARPDBA, ARCKCN, ARTARA", new[] { "AREKEY", "ARHMCO", "ARAN8", "ARPTAX", "ARTAXX", "ARPDBA", "ARCKCN", "ARTARA" }, isUnique: true, isPrimaryKey: true)
    };
}
