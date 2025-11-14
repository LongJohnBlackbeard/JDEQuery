using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211Z1T - .
/// </summary>
public class F4211Z1T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DZEDUS.
        /// </summary>
        public const string DZEDUS = "DZEDUS";

        /// <summary>
        /// DZEDBT.
        /// </summary>
        public const string DZEDBT = "DZEDBT";

        /// <summary>
        /// DZEDTN.
        /// </summary>
        public const string DZEDTN = "DZEDTN";

        /// <summary>
        /// DZEDLN.
        /// </summary>
        public const string DZEDLN = "DZEDLN";

        /// <summary>
        /// DZKCOO.
        /// </summary>
        public const string DZKCOO = "DZKCOO";

        /// <summary>
        /// DZTUPRC.
        /// </summary>
        public const string DZTUPRC = "DZTUPRC";

        /// <summary>
        /// DZUTA.
        /// </summary>
        public const string DZUTA = "DZUTA";

        /// <summary>
        /// DZTAEXP.
        /// </summary>
        public const string DZTAEXP = "DZTAEXP";

        /// <summary>
        /// DZETA.
        /// </summary>
        public const string DZETA = "DZETA";

        /// <summary>
        /// DZTFUP.
        /// </summary>
        public const string DZTFUP = "DZTFUP";

        /// <summary>
        /// DZFUTA.
        /// </summary>
        public const string DZFUTA = "DZFUTA";

        /// <summary>
        /// DZTFEA.
        /// </summary>
        public const string DZTFEA = "DZTFEA";

        /// <summary>
        /// DZFETA.
        /// </summary>
        public const string DZFETA = "DZFETA";

        /// <summary>
        /// DZTPROV.
        /// </summary>
        public const string DZTPROV = "DZTPROV";

        /// <summary>
        /// DZDTXJ.
        /// </summary>
        public const string DZDTXJ = "DZDTXJ";

        /// <summary>
        /// DZCRCD.
        /// </summary>
        public const string DZCRCD = "DZCRCD";

        /// <summary>
        /// DZUSER.
        /// </summary>
        public const string DZUSER = "DZUSER";

        /// <summary>
        /// DZPID.
        /// </summary>
        public const string DZPID = "DZPID";

        /// <summary>
        /// DZJOBN.
        /// </summary>
        public const string DZJOBN = "DZJOBN";

        /// <summary>
        /// DZUPMJ.
        /// </summary>
        public const string DZUPMJ = "DZUPMJ";

        /// <summary>
        /// DZUPMT.
        /// </summary>
        public const string DZUPMT = "DZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4211Z1T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DZEDUS", "DZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("DZEDBT", "DZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("DZEDTN", "DZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("DZEDLN", "DZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("DZKCOO", "DZKCOO", JdeDataType.String, 10),
        new JdeField("DZTUPRC", "DZTUPRC", JdeDataType.Numeric),
        new JdeField("DZUTA", "DZUTA", JdeDataType.Numeric),
        new JdeField("DZTAEXP", "DZTAEXP", JdeDataType.Numeric),
        new JdeField("DZETA", "DZETA", JdeDataType.Numeric),
        new JdeField("DZTFUP", "DZTFUP", JdeDataType.Numeric),
        new JdeField("DZFUTA", "DZFUTA", JdeDataType.Numeric),
        new JdeField("DZTFEA", "DZTFEA", JdeDataType.Numeric),
        new JdeField("DZFETA", "DZFETA", JdeDataType.Numeric),
        new JdeField("DZTPROV", "DZTPROV", JdeDataType.String, 2),
        new JdeField("DZDTXJ", "DZDTXJ", JdeDataType.Numeric),
        new JdeField("DZCRCD", "DZCRCD", JdeDataType.String, 6),
        new JdeField("DZUSER", "DZUSER", JdeDataType.String, 20),
        new JdeField("DZPID", "DZPID", JdeDataType.String, 20),
        new JdeField("DZJOBN", "DZJOBN", JdeDataType.String, 20),
        new JdeField("DZUPMJ", "DZUPMJ", JdeDataType.Numeric),
        new JdeField("DZUPMT", "DZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211Z1T_0", "Primary Key on DZEDUS, DZEDBT, DZEDTN, DZEDLN", new[] { "DZEDUS", "DZEDBT", "DZEDTN", "DZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
