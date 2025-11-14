using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4020 - .
/// </summary>
public class F4020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARZON.
        /// </summary>
        public const string ARZON = "ARZON";

        /// <summary>
        /// ARSHCM.
        /// </summary>
        public const string ARSHCM = "ARSHCM";

        /// <summary>
        /// ARFRAT.
        /// </summary>
        public const string ARFRAT = "ARFRAT";

        /// <summary>
        /// ARCARS.
        /// </summary>
        public const string ARCARS = "ARCARS";

        /// <summary>
        /// ARMCU.
        /// </summary>
        public const string ARMCU = "ARMCU";

        /// <summary>
        /// ARDCTO.
        /// </summary>
        public const string ARDCTO = "ARDCTO";

        /// <summary>
        /// ARLNTY.
        /// </summary>
        public const string ARLNTY = "ARLNTY";

        /// <summary>
        /// ARTYCN.
        /// </summary>
        public const string ARTYCN = "ARTYCN";

        /// <summary>
        /// ARCSTY.
        /// </summary>
        public const string ARCSTY = "ARCSTY";

        /// <summary>
        /// ARCRTY.
        /// </summary>
        public const string ARCRTY = "ARCRTY";

        /// <summary>
        /// ARRQPK.
        /// </summary>
        public const string ARRQPK = "ARRQPK";

        /// <summary>
        /// ARRQDC.
        /// </summary>
        public const string ARRQDC = "ARRQDC";

        /// <summary>
        /// AREFTJ.
        /// </summary>
        public const string AREFTJ = "AREFTJ";

        /// <summary>
        /// AREFDJ.
        /// </summary>
        public const string AREFDJ = "AREFDJ";

        /// <summary>
        /// ARMNRT.
        /// </summary>
        public const string ARMNRT = "ARMNRT";

        /// <summary>
        /// ARMXRT.
        /// </summary>
        public const string ARMXRT = "ARMXRT";

        /// <summary>
        /// ARRATT.
        /// </summary>
        public const string ARRATT = "ARRATT";

        /// <summary>
        /// ARRBAS.
        /// </summary>
        public const string ARRBAS = "ARRBAS";

        /// <summary>
        /// ARBSRT.
        /// </summary>
        public const string ARBSRT = "ARBSRT";

        /// <summary>
        /// ARSBAS.
        /// </summary>
        public const string ARSBAS = "ARSBAS";

        /// <summary>
        /// ARSRRT.
        /// </summary>
        public const string ARSRRT = "ARSRRT";

        /// <summary>
        /// ARMXDM.
        /// </summary>
        public const string ARMXDM = "ARMXDM";

        /// <summary>
        /// ARMCTY.
        /// </summary>
        public const string ARMCTY = "ARMCTY";

        /// <summary>
        /// ARSHZP.
        /// </summary>
        public const string ARSHZP = "ARSHZP";

        /// <summary>
        /// ARVLUM.
        /// </summary>
        public const string ARVLUM = "ARVLUM";

        /// <summary>
        /// ARWTUM.
        /// </summary>
        public const string ARWTUM = "ARWTUM";

        /// <summary>
        /// ARUM.
        /// </summary>
        public const string ARUM = "ARUM";

        /// <summary>
        /// ARLIM.
        /// </summary>
        public const string ARLIM = "ARLIM";

        /// <summary>
        /// ARMXQT.
        /// </summary>
        public const string ARMXQT = "ARMXQT";

        /// <summary>
        /// ARCRAT.
        /// </summary>
        public const string ARCRAT = "ARCRAT";

        /// <summary>
        /// ARADCG.
        /// </summary>
        public const string ARADCG = "ARADCG";

        /// <summary>
        /// ARADTD.
        /// </summary>
        public const string ARADTD = "ARADTD";
    }

    /// <inheritdoc />
    public override string TableName => "F4020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARZON", "ARZON", JdeDataType.String, 6, true, true),
        new JdeField("ARSHCM", "ARSHCM", JdeDataType.String, 6, true, true),
        new JdeField("ARFRAT", "ARFRAT", JdeDataType.String, 20, true, true),
        new JdeField("ARCARS", "ARCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMCU", "ARMCU", JdeDataType.String, 24, true, true),
        new JdeField("ARDCTO", "ARDCTO", JdeDataType.String, 4),
        new JdeField("ARLNTY", "ARLNTY", JdeDataType.String, 4),
        new JdeField("ARTYCN", "ARTYCN", JdeDataType.String, 6),
        new JdeField("ARCSTY", "ARCSTY", JdeDataType.String, 6),
        new JdeField("ARCRTY", "ARCRTY", JdeDataType.String, 6),
        new JdeField("ARRQPK", "ARRQPK", JdeDataType.String, 6),
        new JdeField("ARRQDC", "ARRQDC", JdeDataType.String, 6),
        new JdeField("AREFTJ", "AREFTJ", JdeDataType.Numeric),
        new JdeField("AREFDJ", "AREFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMNRT", "ARMNRT", JdeDataType.Numeric),
        new JdeField("ARMXRT", "ARMXRT", JdeDataType.Numeric),
        new JdeField("ARRATT", "ARRATT", JdeDataType.String, 2),
        new JdeField("ARRBAS", "ARRBAS", JdeDataType.String, 2),
        new JdeField("ARBSRT", "ARBSRT", JdeDataType.Numeric),
        new JdeField("ARSBAS", "ARSBAS", JdeDataType.String, 2),
        new JdeField("ARSRRT", "ARSRRT", JdeDataType.Numeric),
        new JdeField("ARMXDM", "ARMXDM", JdeDataType.String, 6),
        new JdeField("ARMCTY", "ARMCTY", JdeDataType.String, 2),
        new JdeField("ARSHZP", "ARSHZP", JdeDataType.String, 24),
        new JdeField("ARVLUM", "ARVLUM", JdeDataType.String, 4),
        new JdeField("ARWTUM", "ARWTUM", JdeDataType.String, 4),
        new JdeField("ARUM", "ARUM", JdeDataType.String, 4),
        new JdeField("ARLIM", "ARLIM", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMXQT", "ARMXQT", JdeDataType.Numeric),
        new JdeField("ARCRAT", "ARCRAT", JdeDataType.Numeric),
        new JdeField("ARADCG", "ARADCG", JdeDataType.Numeric),
        new JdeField("ARADTD", "ARADTD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4020_0", "Primary Key on ARZON, ARMCU, ARFRAT, AREFDJ, ARSHCM, ARCARS, ARLIM", new[] { "ARZON", "ARMCU", "ARFRAT", "AREFDJ", "ARSHCM", "ARCARS", "ARLIM" }, isUnique: true, isPrimaryKey: true)
    };
}
