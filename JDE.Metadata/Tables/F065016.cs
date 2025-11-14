using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F065016 - .
/// </summary>
public class F065016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YGAN8.
        /// </summary>
        public const string YGAN8 = "YGAN8";

        /// <summary>
        /// YGSSN.
        /// </summary>
        public const string YGSSN = "YGSSN";

        /// <summary>
        /// YGALPH.
        /// </summary>
        public const string YGALPH = "YGALPH";

        /// <summary>
        /// YGHMCO.
        /// </summary>
        public const string YGHMCO = "YGHMCO";

        /// <summary>
        /// YGTAX.
        /// </summary>
        public const string YGTAX = "YGTAX";

        /// <summary>
        /// YGSEQ.
        /// </summary>
        public const string YGSEQ = "YGSEQ";

        /// <summary>
        /// YGFOA#.
        /// </summary>
        public const string YGFOA_ = "YGFOA#";

        /// <summary>
        /// YGOFO#.
        /// </summary>
        public const string YGOFO_ = "YGOFO#";

        /// <summary>
        /// YGIFO#.
        /// </summary>
        public const string YGIFO_ = "YGIFO#";

        /// <summary>
        /// YGSEC.
        /// </summary>
        public const string YGSEC = "YGSEC";

        /// <summary>
        /// YGSCC.
        /// </summary>
        public const string YGSCC = "YGSCC";

        /// <summary>
        /// YGTCOD.
        /// </summary>
        public const string YGTCOD = "YGTCOD";

        /// <summary>
        /// YGPSDT.
        /// </summary>
        public const string YGPSDT = "YGPSDT";

        /// <summary>
        /// YGPTDT.
        /// </summary>
        public const string YGPTDT = "YGPTDT";

        /// <summary>
        /// YGBDM.
        /// </summary>
        public const string YGBDM = "YGBDM";

        /// <summary>
        /// YGFPCD.
        /// </summary>
        public const string YGFPCD = "YGFPCD";

        /// <summary>
        /// YGPREN.
        /// </summary>
        public const string YGPREN = "YGPREN";

        /// <summary>
        /// YGGPA.
        /// </summary>
        public const string YGGPA = "YGGPA";

        /// <summary>
        /// YGDEP1.
        /// </summary>
        public const string YGDEP1 = "YGDEP1";

        /// <summary>
        /// YGDEP2.
        /// </summary>
        public const string YGDEP2 = "YGDEP2";

        /// <summary>
        /// YGDEP3.
        /// </summary>
        public const string YGDEP3 = "YGDEP3";

        /// <summary>
        /// YGDEP4.
        /// </summary>
        public const string YGDEP4 = "YGDEP4";

        /// <summary>
        /// YGDEP5.
        /// </summary>
        public const string YGDEP5 = "YGDEP5";

        /// <summary>
        /// YGDEP6.
        /// </summary>
        public const string YGDEP6 = "YGDEP6";

        /// <summary>
        /// YGUSER.
        /// </summary>
        public const string YGUSER = "YGUSER";

        /// <summary>
        /// YGPID.
        /// </summary>
        public const string YGPID = "YGPID";

        /// <summary>
        /// YGUPMJ.
        /// </summary>
        public const string YGUPMJ = "YGUPMJ";

        /// <summary>
        /// YGAUSPTWP.
        /// </summary>
        public const string YGAUSPTWP = "YGAUSPTWP";
    }

    /// <inheritdoc />
    public override string TableName => "F065016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YGAN8", "YGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YGSSN", "YGSSN", JdeDataType.String, 40),
        new JdeField("YGALPH", "YGALPH", JdeDataType.String, 80),
        new JdeField("YGHMCO", "YGHMCO", JdeDataType.String, 10),
        new JdeField("YGTAX", "YGTAX", JdeDataType.String, 40),
        new JdeField("YGSEQ", "YGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("YGFOA#", "YGFOA#", JdeDataType.String, 34, true, true),
        new JdeField("YGOFO#", "YGOFO#", JdeDataType.String, 18),
        new JdeField("YGIFO#", "YGIFO#", JdeDataType.String, 18),
        new JdeField("YGSEC", "YGSEC", JdeDataType.String, 6),
        new JdeField("YGSCC", "YGSCC", JdeDataType.String, 6),
        new JdeField("YGTCOD", "YGTCOD", JdeDataType.String, 4),
        new JdeField("YGPSDT", "YGPSDT", JdeDataType.Numeric),
        new JdeField("YGPTDT", "YGPTDT", JdeDataType.Numeric),
        new JdeField("YGBDM", "YGBDM", JdeDataType.String, 2, true, true),
        new JdeField("YGFPCD", "YGFPCD", JdeDataType.String, 2),
        new JdeField("YGPREN", "YGPREN", JdeDataType.String, 4),
        new JdeField("YGGPA", "YGGPA", JdeDataType.Numeric),
        new JdeField("YGDEP1", "YGDEP1", JdeDataType.String, 2),
        new JdeField("YGDEP2", "YGDEP2", JdeDataType.String, 2),
        new JdeField("YGDEP3", "YGDEP3", JdeDataType.String, 2),
        new JdeField("YGDEP4", "YGDEP4", JdeDataType.String, 2),
        new JdeField("YGDEP5", "YGDEP5", JdeDataType.String, 2),
        new JdeField("YGDEP6", "YGDEP6", JdeDataType.String, 2),
        new JdeField("YGUSER", "YGUSER", JdeDataType.String, 20),
        new JdeField("YGPID", "YGPID", JdeDataType.String, 20),
        new JdeField("YGUPMJ", "YGUPMJ", JdeDataType.Numeric),
        new JdeField("YGAUSPTWP", "YGAUSPTWP", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F065016_0", "Primary Key on YGAN8, YGSEQ, YGBDM, YGFOA#", new[] { "YGAN8", "YGSEQ", "YGBDM", "YGFOA#" }, isUnique: true, isPrimaryKey: true)
    };
}
