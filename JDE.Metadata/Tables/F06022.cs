using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06022 - .
/// </summary>
public class F06022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAAN8.
        /// </summary>
        public const string JAAN8 = "JAAN8";

        /// <summary>
        /// JARTCD.
        /// </summary>
        public const string JARTCD = "JARTCD";

        /// <summary>
        /// JARTP1.
        /// </summary>
        public const string JARTP1 = "JARTP1";

        /// <summary>
        /// JARTP2.
        /// </summary>
        public const string JARTP2 = "JARTP2";

        /// <summary>
        /// JARTP3.
        /// </summary>
        public const string JARTP3 = "JARTP3";

        /// <summary>
        /// JARTP4.
        /// </summary>
        public const string JARTP4 = "JARTP4";

        /// <summary>
        /// JAPRN1.
        /// </summary>
        public const string JAPRN1 = "JAPRN1";

        /// <summary>
        /// JAPRN2.
        /// </summary>
        public const string JAPRN2 = "JAPRN2";

        /// <summary>
        /// JAPRN3.
        /// </summary>
        public const string JAPRN3 = "JAPRN3";

        /// <summary>
        /// JAPRN4.
        /// </summary>
        public const string JAPRN4 = "JAPRN4";

        /// <summary>
        /// JANRD1.
        /// </summary>
        public const string JANRD1 = "JANRD1";

        /// <summary>
        /// JANRD2.
        /// </summary>
        public const string JANRD2 = "JANRD2";

        /// <summary>
        /// JANRD3.
        /// </summary>
        public const string JANRD3 = "JANRD3";

        /// <summary>
        /// JANRD4.
        /// </summary>
        public const string JANRD4 = "JANRD4";

        /// <summary>
        /// JALCD1.
        /// </summary>
        public const string JALCD1 = "JALCD1";

        /// <summary>
        /// JALCD2.
        /// </summary>
        public const string JALCD2 = "JALCD2";

        /// <summary>
        /// JALCD3.
        /// </summary>
        public const string JALCD3 = "JALCD3";

        /// <summary>
        /// JALCD4.
        /// </summary>
        public const string JALCD4 = "JALCD4";

        /// <summary>
        /// JAJBCD.
        /// </summary>
        public const string JAJBCD = "JAJBCD";

        /// <summary>
        /// JAJBST.
        /// </summary>
        public const string JAJBST = "JAJBST";

        /// <summary>
        /// JAEFTE.
        /// </summary>
        public const string JAEFTE = "JAEFTE";

        /// <summary>
        /// JAHRWR.
        /// </summary>
        public const string JAHRWR = "JAHRWR";

        /// <summary>
        /// JAHRWT.
        /// </summary>
        public const string JAHRWT = "JAHRWT";

        /// <summary>
        /// JAHRWO.
        /// </summary>
        public const string JAHRWO = "JAHRWO";

        /// <summary>
        /// JAHRWV.
        /// </summary>
        public const string JAHRWV = "JAHRWV";
    }

    /// <inheritdoc />
    public override string TableName => "F06022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAAN8", "JAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JARTCD", "JARTCD", JdeDataType.String, 2),
        new JdeField("JARTP1", "JARTP1", JdeDataType.Numeric),
        new JdeField("JARTP2", "JARTP2", JdeDataType.Numeric),
        new JdeField("JARTP3", "JARTP3", JdeDataType.Numeric),
        new JdeField("JARTP4", "JARTP4", JdeDataType.Numeric),
        new JdeField("JAPRN1", "JAPRN1", JdeDataType.Numeric),
        new JdeField("JAPRN2", "JAPRN2", JdeDataType.Numeric),
        new JdeField("JAPRN3", "JAPRN3", JdeDataType.Numeric),
        new JdeField("JAPRN4", "JAPRN4", JdeDataType.Numeric),
        new JdeField("JANRD1", "JANRD1", JdeDataType.Numeric),
        new JdeField("JANRD2", "JANRD2", JdeDataType.Numeric),
        new JdeField("JANRD3", "JANRD3", JdeDataType.Numeric),
        new JdeField("JANRD4", "JANRD4", JdeDataType.Numeric),
        new JdeField("JALCD1", "JALCD1", JdeDataType.Numeric),
        new JdeField("JALCD2", "JALCD2", JdeDataType.Numeric),
        new JdeField("JALCD3", "JALCD3", JdeDataType.Numeric),
        new JdeField("JALCD4", "JALCD4", JdeDataType.Numeric),
        new JdeField("JAJBCD", "JAJBCD", JdeDataType.String, 12),
        new JdeField("JAJBST", "JAJBST", JdeDataType.String, 8),
        new JdeField("JAEFTE", "JAEFTE", JdeDataType.Numeric),
        new JdeField("JAHRWR", "JAHRWR", JdeDataType.Numeric),
        new JdeField("JAHRWT", "JAHRWT", JdeDataType.Numeric),
        new JdeField("JAHRWO", "JAHRWO", JdeDataType.Numeric),
        new JdeField("JAHRWV", "JAHRWV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06022_0", "Primary Key on JAAN8", new[] { "JAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
